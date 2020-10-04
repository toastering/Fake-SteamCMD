using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realsteamcmd
{
    class Strings
    {
        public static string intro = @"Looks like steam didn't shutdown cleanly, scheduling immediate update check
[  0%] Checking for available updates...
[----] Verifying installation...
Steam Console Client (c) Valve Corporation
-- type 'quit' to exit --
Loading Steam API...OK.
";
        public static string helpmsg = @"
Usage:  steamcmd ["" + COMMAND[ARG]...""]...
  or:   steamcmd +runscript SCRIPTFILE

Help topics - type ""help <topic>"" or run with ""--help <topic>"" for more information:

               login : Logging in to Steam
             scripts : Executing a sequence of commands via a script file
         commandline : Executing commands directly via the OS command line
             convars : Options and settings that affect this program session
           app_build : Building Steam application content (only for licensed Steam application developers)
          app_update : Installing/updating a Steam application on the local filesystem (EG dedicated servers)


You can also type ""find <string>"" to see a list of all commands and convars that contain or reference<string>.

";
    }
}
