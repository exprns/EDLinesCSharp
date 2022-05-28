# Library to find lines on image

Source C++ https://github.com/frotms/line_detector.git
Wrapped to C# by swig

## Wrapped by swig

### Install swig

#### Linux

sudo apt install swig

Or you can use guide http://swig.org/svn.html (there are tests and you can check missing libs)

### Обертывание

Create and fill a file with extension .i ( http://www.swig.org/Doc4.0/SWIGDocumentation.html# )
In directory contains .cpp, .h, .i files execute swig -csharp -c++ edlines.i.
Create library by cmake from files .cpp, .h, .cxx.