// See https://aka.ms/new-console-template for more information
using CompositePattern;

//Console.WriteLine("Hello, World!");

IFileComponent file1 = new FileLeaf("file 1", 100);
IFileComponent file2 = new FileLeaf("file 2", 200);
IFileComponent file3 = new FileLeaf("file 3", 300);

List<IFileComponent> files = new List<IFileComponent>() { file1, file2, file3};

FolderComposite folders = new FolderComposite(files);

folders.ShowProperty();
Console.WriteLine(folders.TotalSize());