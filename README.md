# AMDaemon Test #

An experimental artifact of `amdaemon.exe` memory-mapped file.  
Full experiment journey can be seen in [here](https://lab.cxo2.me/what-is-amdaemon/) (Warning: rubbish grammar and writing ahead).

## Build Instructions ##

1. Make sure to place required libs inside `Source\Dummy\Libs`
2. Open the solution file with your favorite IDE and Build the solutions
3. The executable can be found in `Build\<Build Config>\`

## Usage ##

### Dummy ###

1. Start `amdaemon.exe` with your favorite emulator
2. Start `Dummy` project

### Memory-Mapped Files Dumper (MMF-Dumper) ###

1. Start `amdaemon.exe` with your favorite emulator
2. Start `MMF-Dumper` project
3. The dumped files can be found in the same directory of the executable

### Memory-Mapped Files Loader (MMF-Loader) ###

1. Dump Memory-Mapped files (see above instructions)
2. Make sure that dumped file is located in build folder then Start `MMF-Loader` project
3. Start `Dummy` project to test the loaded file or use [`Process Explorer`](https://docs.microsoft.com/en-us/sysinternals/downloads/process-explorer) to observe the MMF handles.

## License ##

[No License / Public Domain](https://github.com/SirusDoma/AMDaemon-Test/blob/master/LICENSE).
