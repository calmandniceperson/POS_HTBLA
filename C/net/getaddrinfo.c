#include <stdio.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netdb.h>
#include <arpa/inet.h>
#include <netinet/in.h>

int main(int argc, char *argv[])
{
  struct addrinfo hints, *res, *p;
  int status;
  char ipstr[INET6_ADDRSTRLEN]; // will store the ip address as a char array

  if(argc != 2)
  {
    fprintf(stderr,"usage: ./<name> hostname\n");
    return 1;
  }

  memset(&hints, 0, sizeof hints);
  hints.ai_family = AF_UNSPEC; // unspecified version of internet protocol (AF_INET or AF_INET6 to force version)
  hints.ai_socktype = SOCK_STREAM; // using layer 4 tcp

  if((status = getaddrinfo(argv[1], NULL, &hints, &res)) != 0)
  {
    fprintf(stderr, "getaddrinfo: %s\n", gai_strerror(status));
    return 2;
  }

  printf("IP addresses for %s\n\n", argv[1]);

  for(p = res; p != NULL; p = p->ai_next)
  {
    void *addr; // stores the address itself
    char *ipver; // stores the ip version used

    if(p->ai_family == AF_INET) // IPv4
    {
      struct sockaddr_in *ipv4 = (struct sockaddr_in *)p->ai_addr;
      addr = &(ipv4->sin_addr);
      ipver = "IPv4";
    }
    else
    {
      struct sockaddr_in6 *ipv6 = (struct sockaddr_in6 *)p->ai_addr;
      addr = &(ipv6->sin6_addr);
      ipver = "IPv6";
    }
    // convert IP to string and print
    inet_ntop(p->ai_family, addr, ipstr, sizeof ipstr /*now storing the ip address as a char array*/);
    printf("%s: %s\n", ipver, ipstr);
  }

  freeaddrinfo(res); // free the linked list

  return 0;
}
