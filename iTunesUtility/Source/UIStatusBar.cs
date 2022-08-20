using System;
using System.Windows.Forms;


namespace iTunesUtility.Source {

	//////////////////////////////////////////////////////////////////////////////////
	public partial class UIStatusBar : UserControl {

		iTunesUtilityWindow mainWindow;
		Progressbar m_progressbar;

		public Progressbar progressbar => m_progressbar;


		/////////////////////////////////////////
		public UIStatusBar( iTunesUtilityWindow window ) {
			InitializeComponent();
			mainWindow = window;
			Dock = DockStyle.Bottom;
			mainWindow.applyTrackInfoToListView += OnApplyTrackInfoToListView;

			m_progressbar = new Progressbar( window, toolStripProgressBar1 );

			ShowStatusbarControl( false );
		}


		/////////////////////////////////////////
		public void ShowStatusbarControl( bool b, string text = null ) {
			mainWindow.Invoke( new Action( () => {
				toolStripStatusLabel1.Visible = b;
				toolStripProgressBar1.Visible = b;
				if( !string.IsNullOrEmpty( text ) ) toolStripStatusLabel1.Text = text;
			} ) );
		}


		/////////////////////////////////////////
		void OnApplyTrackInfoToListView( TrackInfo[] m_TrackInfo, EFilterType m_filterMode ) {
			toolStripStatusLabel2.Text = $"{m_TrackInfo.Length} 曲:";
		}
	}
}
