cmake_minimum_required(VERSION 3.14)
project(backend)

# GoogleTest requires at least C++14
set(CMAKE_CXX_STANDARD 14)

include(FetchContent)
FetchContent_Declare(
  googletest
  URL https://github.com/google/googletest/archive/03597a01ee50ed33e9dfd640b249b4be3799d395.zip
)
# For Windows: Prevent overriding the parent project's compiler/linker settings
set(gtest_force_shared_crt ON CACHE BOOL "" FORCE)
FetchContent_MakeAvailable(googletest)


enable_testing()

add_executable(
  hello_test
  hello_test.cc
  gamelauncher.cpp
  gamesDB.cpp
)

target_link_libraries(
  hello_test
  GTest::gtest_main
)

include(GoogleTest)
gtest_discover_tests(hello_test)
















# cmake_minimum_required(VERSION 3.8)

# set(This Example)

# project(${This} C CXX)

# set(CMAKE_C_STANDARD 99)
# set(CMAKE_CXX_STANDARD 11)
# set(CMAKE_POSITION_INDEPENDENT_CODE ON)

# enable_testing()

# add_subdirectory(googletest)

# set(Headers
#    Example.hpp
# )

# set(Sources
#    Example.cpp
# )

# add_library(${This} STATIC ${Sources} ${Headers})

# add_subdirectory(test)
