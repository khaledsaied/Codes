class BuildAProgram
{
	private list<compiledFiles> listofCompiledFiles
	public void Build

		{
			foreach(file in filesList)
			{ 
				listOfCompiledFiles.Add(Compile(file));
			}
		
			Link(listofCompiledFIles);
		}
		
		
		public virtual Compile(file) = 0;
		public virtual Link() = 0;
		public virtual GenerateExecuteable() = 0;
}
