///////////////////////////////////////////////////////////
//  Log.cs
//  Implementation of the Class Log
//  Generated by Enterprise Architect
//  Created on:      07-apr-2013 10:51:14
//  Original author: Khaled
///////////////////////////////////////////////////////////




using Log;
namespace Log {
	public class Log {

		public Log.IFileHandler m_IFileHandler;
		public Log.ILog m_ILog;

		public Log(){

		}

		~Log(){

		}

		public virtual void Dispose(){

		}

		/// 
		/// <param name="ffff"></param>
		public Log({ get; set; } ffff = 8){

		}

		public LogLevel logLevel{
			get;
			set;
		}

		/// 
		/// <param name="fh"></param>
		public void LogThis(IFileHandler fh){

		}

		public DateTimeOffset Timestamp{
			get;
			set;
		}

	}//end Log

}//end namespace Log