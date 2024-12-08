using Microsoft.VisualBasic;

namespace Utils
{
    public class CheckFlags
    {
        private bool shouldTerminateOnNonDirectionalKeys = false;

        public CheckFlags(string[] args)
        {
            ReadFlags(args);
        }
        public void ReadFlags(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--terminateOnNonDirectionKeys":
                    case "-t":
                        shouldTerminateOnNonDirectionalKeys = true;
                        break;
                    default:
                        return;
                }
            }
        }

        public bool ShouldTerminateOnNonDirectionalKeys
        {
            get
            {
                return shouldTerminateOnNonDirectionalKeys;
            }
            set
            {
                shouldTerminateOnNonDirectionalKeys = value;
            }
        }
    }
}