
protoc=../packages/Google.Protobuf.Tools.3.2.0/tools/windows_x64/protoc.exe
src_dir=./Protobuf/Model.Proto
dst_dir=./Protobuf/Model

rm -rf $dst_dir/*.cs
$protoc -I=$src_dir --csharp_out=$dst_dir $src_dir/*.proto
