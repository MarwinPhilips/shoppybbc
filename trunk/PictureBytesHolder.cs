using System;
using System.Collections.Generic;
using System.Text;

namespace CamView
{
    class PictureBytesHolder
    {
        private byte[] m_bytes;
	    private bool m_set;
    	
	    public PictureBytesHolder() {
		    m_set = false;
	    }
    	
	    public void SetBytes(byte[] bytes) {
		    m_set = true;
		    m_bytes = bytes;
	    }
    	
	    public byte[] GetBytes() {
		    if (m_set) {
                byte[] b = new byte[m_bytes.Length];
                m_bytes.CopyTo(b, 0);
			    return b;
		    }
		    else {
			    return null;
		    }
	    }
	
    }
}
