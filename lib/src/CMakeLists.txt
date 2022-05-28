cmake_minimum_required(VERSION 3.4)

project(libedlines)


add_library(edlines SHARED
        edlines.h
        edlines.cpp
        edlines_wrap.cxx
        )
