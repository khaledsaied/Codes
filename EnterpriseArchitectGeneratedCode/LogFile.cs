///////////////////////////////////////////////////////////
//  LogFile.cs
//  Implementation of the Class LogFile
//  Generated by Enterprise Architect
//  Created on:      07-apr-2013 16:49:50
//  Original author: Khaled
///////////////////////////////////////////////////////////




using Log;
namespace Log {
	public class LogFile {

		public Log.AtcFileHandler m_AtcFileHandler;
		public Log.TracksFileHandler m_TracksFileHandler;

		public LogFile(){

		}

		~LogFile(){

		}

		public virtual void Dispose(){

		}

		/// 
		/// <param name="loggedItem"></param>
		public string getLoggedItem(IFileHandler loggedItem){

			return "";
		}

		/// 
		/// <param name="file"></param>
		public void writer(string file){

		}

	}//end LogFile

}//end namespace Log