///////////////////////////////////////////////////////////
//  IFileHandler.cs
//  Implementation of the Class IFileHandler
//  Generated by Enterprise Architect
//  Created on:      07-apr-2013 10:51:16
//  Original author: Khaled
///////////////////////////////////////////////////////////




using Log;
namespace Log {
	public class IFileHandler {

		public IFileHandler(){

		}

		~IFileHandler(){

		}

		public virtual void Dispose(){

		}

		/// 
		/// <param name="list"></param>
		public abstract void LogThis(List <T> list);

		/// 
		/// <param name="logLevel"></param>
		/// <param name="msg"></param>
		public void write(LogLevel logLevel, string msg){

		}

	}//end IFileHandler

}//end namespace Log