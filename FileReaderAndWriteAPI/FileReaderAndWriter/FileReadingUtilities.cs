using Models;

namespace FileReaderAndWriteAPI.FileReaderAndWriter
{
    public class FileReadingUtilities
    {

        public static List<FileDetails> GetAllFilesInAPath(FolderDetails? folderDetails)
        {
         //   folderDetails.FolderPath = @"C:\Users\max\Downloads";
           
            List<FileDetails> list = new();
           
                //Directory.EnumerateFileSystemEntries
                var files = Directory.EnumerateFileSystemEntries(folderDetails.FolderPath);
                foreach (var file in files)
                {
                  
                    FileInfo info = new FileInfo(file);
                    var name = info.Name;
                    var extension = info.Extension;
                    String? type;
                //
            //in order to prevent the program confusing any dot with extension the attribute of the file
            //has to be checked
                FileAttributes attr = File.GetAttributes(file);

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    type = "Folder";
                    extension = null;
                }
                else
                {
                    type = "File";
                }
                  

                //
                //if (extension=="")
                //    {
                       
                //        type = "Folder";
                //        extension = null;
                //    }
                //    else
                //    {
                //        type = "File";
                //    }


                    list.Add(new FileDetails()
                    {
                        Name = name,
                        Extention = extension,
                        Type = type
                    });

                    
                }
            

            return list;
        }
    }
}
