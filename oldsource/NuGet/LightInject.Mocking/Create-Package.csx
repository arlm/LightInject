#load "..\Common.csx"

Console.WriteLine("Start building the LightInject.Mocking NuGet package");
string currentDirectory = Directory.GetCurrentDirectory();

string inputDirectory = Path.Combine(currentDirectory, @"..\..\LightInject.Mocking");
string inputPath = Path.Combine(inputDirectory, @"LightInjectMocking.cs");
string outputFile = "LightInjectMocking.cs.pp";


string outputDirectory = Path.Combine(currentDirectory, @"package\content\net40");
Directory.CreateDirectory(outputDirectory);
Console.WriteLine("Current output directory is : {0}", outputDirectory);

SourceWriter.Write("NET", inputPath, Path.Combine(outputDirectory, outputFile), true); 

outputDirectory = Path.Combine(currentDirectory, @"package\content\net45");
Directory.CreateDirectory(outputDirectory);
Console.WriteLine("Current output directory is : {0}", outputDirectory);
SourceWriter.Write("NET", inputPath, Path.Combine(outputDirectory, outputFile), true); 

outputDirectory = Path.Combine(currentDirectory, @"package\content\netcore45");
Directory.CreateDirectory(outputDirectory);
Console.WriteLine("Current output directory is : {0}", outputDirectory);
SourceWriter.Write("NETFX_CORE", inputPath, Path.Combine(outputDirectory, outputFile), true); 


string pathToNuGet = Path.Combine(currentDirectory, @"..\NuGet.exe");
string pathSpecification = Path.Combine(currentDirectory, @"package\LightInject.Mocking.nuspec");
string packageOutputDirectory = Path.Combine(currentDirectory , @"..");

NuGet.CreatePackage(pathToNuGet, pathSpecification, packageOutputDirectory);

Console.WriteLine("Finished building the LightInject.Mocking NuGet package");