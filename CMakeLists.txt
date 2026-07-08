cmake_minimum_required(VERSION 3.15...3.30)
project(Tengine VERSION 1.0 
		DESCRIPTION "A very rudementary game engine"
		LANGUAGES CXX)
file(GLOB src # Gets files in src folder and puts it into a variable
     "src/*.h"
     "src/*.cpp"
)
#add_subdirectory(sdl EXCLUDE_FROM_ALL) # Allows CMakeLists text file from SDL to be available. 
add_executable(${PROJECT_NAME} ${src})
# add_subdirectory(sdl EXCLUDE_FROM_ALL)

find_package(SDL2 REQUIRED)

target_include_directories(Tengine PRIVATE ${SDL2_INCLUDE_DIRS})
target_link_libraries(Tengine PRIVATE ${SDL2_LIBRARIES})


# SDL2::SDL2main may or may not be available. It is e.g. required by Windows GUI applications
#if(TARGET SDL2::SDL2main) # Target is from sdl2 cmakelist file. SDL2main is a library.
    # It has an implicit dependency on SDL2 functions, so it MUST be added before SDL2::SDL2 (or SDL2::SDL2-static)
    #target_link_libraries(${PROJECT_NAME} PRIVATE SDL2::SDL2main) # Link the sdl2main library to this current project.
    #endif()

# Link to the actual SDL2 library. SDL2::SDL2 is the shared SDL library, SDL2::SDL2-static is the static SDL libarary.
#target_link_libraries(${PROJECT_NAME} PRIVATE SDL2::SDL2) # Link the sdl2 library to this current project

# SCOPE NOTES:
# PRIVATE: The libraries are only used for this target and not by any targets that depend on it.
# PUBLIC: The libraries are used by this target and also by any targets that depend on it.
# INTERFACE: The libraries are not used by this target but are required by targets that depend on it.
