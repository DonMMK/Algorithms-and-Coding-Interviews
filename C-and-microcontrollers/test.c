#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>

int main(int argc, char *argv[])
{
    int status;
    pid_t pid;
    char *args[] = {"./test", NULL};

    pid = fork();
    if (pid == 0) {
        execvp(args[0], args);
        exit(0);
    } else {
        waitpid(pid, &status, 0);
    }

    return 0;
}