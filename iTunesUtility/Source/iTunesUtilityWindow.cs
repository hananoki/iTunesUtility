using HananokiLib;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using iTunesUtility.Source;
using iTunesLib;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iTunesUtility {
	public partial class iTunesUtilityWindow : Form {

		static iTunesUtilityWindow instance;

		EFilterType m_filterMode;


		UIStatusBar m_uiStatus;
		UIListView m_uiListView;
		UIToolBar m_uiToolBar;

		public static UIStatusBar uiStatus => instance.m_uiStatus;
		public static UIListView uiListView => instance.m_uiListView;
		public static UIToolBar uiToolBar => instance.m_uiToolBar;

		public Action<TrackInfo[], EFilterType> applyTrackInfoToListView;
		public Action<EFilterType> applyFilter;

		public static Config config => AppWork.config;

		/////////////////////////////////////////
		public iTunesUtilityWindow() {
			InitializeComponent();
			instance = this;

			AppWork.config = new Config();
		}


		/////////////////////////////////////////
		void Form1_Load( object a1, EventArgs a2 ) {
			Font = SystemFonts.IconTitleFont;

			m_uiStatus = new UIStatusBar( this );
			m_uiToolBar = new UIToolBar( this );
			m_uiListView = new UIListView( this );
			Controls.Add( m_uiStatus );
			Controls.Add( m_uiToolBar );
			panel1.Controls.Add( m_uiListView );

			AppWork.ReadLibrary( AppWork.iTunesLibraryPath2 );

			if( 0 < AppWork.m_TrackInfo.Length ) {
				ApplyTrackInfoToListView();
			}

			Helper.ReadJson( ref AppWork.config, Helper.configPath );
			AppWork.config.RollbackWindow( this );
			m_uiToolBar.SetConnectStatus( iTunesHelper.IsAlive() );
			SetCheckedFillter( 0 );

			if( config.playlistFolderPath.IsEmpty() ) {
				config.playlistFolderPath = Directory.GetCurrentDirectory();
			}

			////Debug.Log( Helper.IsAdministrator().ToString() );
			//if( !Helper.IsAdministrator() ) {
			//	MainMenuItem_RegisteriTunesLibrary.Visible = false;
			//	Context_RegisterLibrary.Visible = false;
			//}
			//else {
			//	this.Text = this.Text + " : 管理者";
			//}

#if false
			//Win32.TOKEN_ELEVATION_TYPE tet = Win32.GetTokenElevationType();
			//if( tet == Win32.TOKEN_ELEVATION_TYPE.TokenElevationTypeDefault ) {
			//	Debug.Log( "UACが無効になっているか、標準ユーザーです" );
			//}
			//else if( tet == Win32.TOKEN_ELEVATION_TYPE.TokenElevationTypeFull ) {
			//	Debug.Log( "UACが有効になっており、昇格しています" );
			//}
			//else if( tet == Win32.TOKEN_ELEVATION_TYPE.TokenElevationTypeLimited ) {
			//	Debug.Log( "UACが有効になっており、昇格していません" );
			//}
#endif
		}


		/////////////////////////////////////////
		void Form1_FormClosing( object sender, FormClosingEventArgs e ) {
			iTunesHelper.Dettach();

			config.BackupWindow( this );
			Helper.WriteJson( config, Helper.configPath );
		}


		/////////////////////////////////////////
		public void SetCheckedFillter( EFilterType n ) {
			m_filterMode = n;
			applyFilter?.Invoke( n );
		}


		/////////////////////////////////////////
		public static void ApplyTrackInfoToListView() {
			instance.applyTrackInfoToListView?.Invoke( AppWork.m_TrackInfo, instance.m_filterMode );
		}
	}
}