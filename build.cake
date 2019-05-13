#addin "wk.StartProcess"
//#addin "wk.PomParser"

using PS = StartProcess.Processor;

//var pom = PomParser.Parser.Parse("pom.xml");
var version = "0.1." + Argument("vv", "1");

Task("Compile").Does(() => {
    PS.StartProcess($"mvn clean compile test-compile -Dversion={version}");
});

Task("Create-Jar")
    .IsDependentOn("Compile")
    .Does(() => {
        PS.StartProcess($@"mvn assembly:assembly -DdescriptorId=jar-with-dependencies -Dversion={version}");

        var path = "publish";
        CreateDirectory(path);
        CleanDirectory(path);
        CopyFiles("target/*.jar", path);
    });

Task("Run-Jar")
    .Does(() => {
        PS.StartProcess($@"java -Dfile.encoding=UTF-8 -jar target/A-{version}-jar-with-dependencies.jar 9090");


    });


var target = Argument("target", "Compile");
RunTarget(target);