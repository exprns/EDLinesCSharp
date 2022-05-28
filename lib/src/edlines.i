%module edlines 
%include "std_vector.i"

%{
    #include "edlines.h"
%}

namespace std {
%template(List_line_float_t) vector<line_float_t>;
}

%include "edlines.h"
