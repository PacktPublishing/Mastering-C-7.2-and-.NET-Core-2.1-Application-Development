# Clean all artifacts then build and measure build times
cd Build20
if(test-path obj){
    rm -r obj
}
if(test-path bin){
    rm -r bin
}
write-host "Building Core 2.0"
Measure-Command { dotnet build }
cd ..
cd Build20
if(test-path obj){
    rm -r obj
}
if(test-path bin){
    rm -r bin
}
write-host "Building Core 2.1"
Measure-Command { dotnet build }
cd ..