#!/bin/bash

scriptdir=`dirname "$BASH_SOURCE"`

if [[ "$OSTYPE" == "darwin"* ]]; then
  libname=libSQLite.Interop.dylib
else
  libname=libSQLite.Interop.so
fi

if [[ -z "$SQLITE_NET_YEAR" ]]; then
  SQLITE_NET_YEAR=2013
fi

pushd "$scriptdir/.."
mono Externals/Eagle/bin/EagleShell.exe -preInitialize "set root_path {$scriptdir/..}; set test_configuration Debug; set test_year $SQLITE_NET_YEAR; set build_directory {bin/$SQLITE_NET_YEAR/Debug$SQLITE_NET_CONFIGURATION_SUFFIX/bin}; set interop_assembly_file_names $libname" -initialize -postInitialize "unset no(deleteSqliteImplicitNativeFiles); unset no(copySqliteImplicitNativeFiles)" -file Tests/all.eagle "$@"
popd
