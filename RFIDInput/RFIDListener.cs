using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phidgets.Events;
using Phidgets;

namespace Shoppy.RFIDInput
{
    // Diese Klasse ist als Singleton programmiert und als Erzähler des Observer-Designpatterns.
    // Sie erzeugt die Events RFIDAttached und RFIDchanged.
    public class RFIDListener 
    {
        private static RFIDListener instance;
        private RFID rfid;
        // Delegate welches das RFIDAttached Event vereinfacht auf bool
        public delegate void RFIDAttachedChangeEventHandler(bool IsAttached);
        public event RFIDAttachedChangeEventHandler RFIDAttached;
        // Delegate welches das RFIDchanged Event vereinfacht auf string
        public delegate void RFIDTagChangedEventHandler(string newRFID); 
        public event RFIDTagChangedEventHandler RFIDchanged;
       

        private bool _isAttached;
        //getter/setter welcher beim set das RFIDAttached-Event erzeugt.
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
        // Getter/Setter welcher beim Setten das RFIDchanged-Event erzeugt.
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
        // Gibt die eigene Instanz zurück (Singleton)
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
        // Die Variable isAttached wird auf den aktuellen Zustand der Variable rfid.Attached gesetzt.
        public void CheckAttached()
        {
            isAttached = rfid.Attached;
        }
    }
}
