/* 
	make sure to install glfw and opengl (mesa)
	
  examples:
 	(g++ main.cpp -L/usr/include/GL -lglfw -o main)
 	(g++ main.cpp - lgl -lglfw -o main)

  gl import not needed because GLFW takes care of it:
  g++ main.cpp -std=c++11 -lglfw -o <name>
 */
#include <iostream>
#include <stdio.h>
#include <stdlib.h>

#include <GL/glew.h>
#include <GL/gl.h>
#define GLFW_INCLUDE_GLU
#include <GLFW/glfw3.h>

int main(){
  if(!glfwInit()){
    std::cout << "Failed to initialize GLFW\n";
  }

  glfwWindowHint(GLFW_SAMPLES, 4); // 
  glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 4); // opengl 4
  glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 3); // opengl 3 minimum requirement
  glfwWindowHint(GLFW_OPENGL_FORWARD_COMPAT, GL_TRUE);
  glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);

  GLFWwindow* window;
  window = glfwCreateWindow(1024, 768, "My first OpenGL window", NULL, NULL); // windowed 
  //window = glfwCreateWindow(1920, 1080, "My first OpenGL window", glfwGetPrimaryMonitor(), NULL); // fullscreen

  if(!window){
  	glfwTerminate();
  	return 0;
  }

  glfwMakeContextCurrent(window); // make the created window the current context
  glfwSetInputMode(window, GLFW_STICKY_KEYS, GL_TRUE); // enable input

  // keep the window alive until the ESCAPE key is pressed
  do{
  	glfwSwapBuffers(window);
  	glfwPollEvents();
  }while(glfwGetKey(window, GLFW_KEY_ESCAPE) != GLFW_PRESS && glfwWindowShouldClose(window) == 0);
  return 0;
}