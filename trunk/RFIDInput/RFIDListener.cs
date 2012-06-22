using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phidgets.Events;
using Phidgets;

namespace Shoppy.RFIDInput
{
    public class RFIDListener
    {
        private static RFIDListener instance;
        private RFID rfid;
        
        public delegate void RFIDAttachedChangeEventHandler(bool IsAttached);
        public event RFIDAttachedChangeEventHandler RFIDAttached;

        public delegate void RFIDTagChangedEventHandler(string newRFID); 
        public event RFIDTagChangedEventHandler RFIDchanged;
       

        private bool _isAttached;
        public bool isAttached
        {
            get { return this._isAttached; }
            set
            {
                this._isAttached = value;
                if (this.RFIDAttached != null)
                    this.RFIDAttached(value);
            }
        }
        private string _rfidtag;
        public String rfidtag
        {
            get { return this._rfidtag; }
            set
            {
                this._rfidtag = value;
                if (this.RFIDchanged != null)
                    this.RFIDchanged(value);
            }
        }
        private RFIDListener(){
            rfidtag = "";
            isAttached = false;
            MyLoad();
        }
        public static RFIDListener GetInstance()
        {
            if (instance == null) { instance = new RFIDListener(); }
            return instance;
        }

        void rfid_Tag(object sender, TagEventArgs e)
        {
            if (_rfidtag != e.Tag)
            {
                rfidtag = e.Tag;
            }
        }

        void rfid_TagLost(object sender, TagEventArgs e)
        {
            if(_rfidtag != "")
                rfidtag = "";
        }

        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;

            if (rfid.outputs.Count > 0 && !_isAttached)
            {
                isAttached = true;

            }
            rfid.Antenna = true;
            
        }
        
        void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;
            if (rfid.outputs.Count < 0 && _isAttached)
            {
                isAttached = false;
            }
            rfid.Antenna = false;
        }

        private void MyLoad()
        {
            if (rfid == null)
            {
                rfid = new RFID();
            }
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            rfid.open(-1);
            
        }
        public void CheckAttached()
        {
            isAttached = rfid.Attached;
        }
    }
}
