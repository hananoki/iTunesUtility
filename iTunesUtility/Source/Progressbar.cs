using System;
using System.Windows.Forms;

namespace iTunesUtility {
	public class Progressbar {
		float f;
		float ff;
		Control m_control;
		ToolStripProgressBar m_statusProgressBar1;

		public Progressbar( Control control, ToolStripProgressBar progressBar ) {
			m_control = control;
			m_statusProgressBar1 = progressBar;
		}

		public void Begin( int length ) {
			f = 100.0f / (float) ( length );
			ff = 0.0f;
		}

		public void Next() {
			ff += f;
			if( 100.0f < ff ) {
				ff = 100.0f;
			}
			m_control.Invoke( new Action( () => {
				m_statusProgressBar1.Value = (int) ff;
			} ) );
		}
	}
}
