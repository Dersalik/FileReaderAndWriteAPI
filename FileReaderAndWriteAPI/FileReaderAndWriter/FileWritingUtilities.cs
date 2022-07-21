using Models;

namespace FileReaderAndWriteAPI.FileReaderAndWriter
{
    public class FileWritingUtilities
    {

        public static String WriteAllFilesInAPath(FileStructure fs)
        {
           
                foreach(var file in fs.files)
                {
                    //Directory.CreateDirectory(Path.Combine());
                    // File.Create(Path.Combine());
                    if(file.Type.ToLower()== "folder")
                    {
                        if (file.Extention == null)
                        {
                            
                                Directory.CreateDirectory(Path.Combine(fs.Folder.FolderPath, file.Name));

                            
                        }
                    }

                    if (file.Type.ToLower() == "file")
                    {
                      
                        File.Create(Path.Combine(fs.Folder.FolderPath,file.Name));
                    }

                }
                return "Successfully all the files were created";
          
            

        }
    }
}
