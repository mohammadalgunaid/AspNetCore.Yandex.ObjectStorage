ApiKey=$1
Source=$2

nuget pack ./AspNetCore.Yandex.ObjectStorage/AspNetCore.Yandex.ObjectStorage.nuspec -Verbosity detailed

nuget push ./AspNetCore.Yandex.ObjectStorage.*.nupkg -Verbosity detailed -ApiKey $ApiKey -Source $Source