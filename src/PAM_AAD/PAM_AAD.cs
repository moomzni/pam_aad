#define PAM_SM_ACCOUNT
#define PAM_SM_AUTH
#define PAM_SM_PASSWORD
#define PAM_SM_SESSION

using System;
using System.Runtime.InteropServices;
using PAM_Types;

namespace PAM_AAD
{
    public class PAM_API
    {
        /* PAM entry point for accounting */
        public int pam_sm_acct_mgmt([MarshalAs(UnmanagedType.LPStruct)] pam_handle pamh, int flags, int argc, [MarshalAs(UnmanagedType.LPTStr)] string argv)
        {
            Console.Write("pam_sm_acct_mgmt init");
            return PAM_Vars.PAM_IGNORE;
        }

        /* PAM entry point for authentication verification */
        public int pam_sm_authenticate([MarshalAs(UnmanagedType.LPStruct)] pam_handle pamh, int flags, int argc, [MarshalAs(UnmanagedType.LPTStr)] string argv)
        {
            Console.Write("pam_sm_authenticate init");
            return PAM_Vars.PAM_IGNORE;
        }

        /*
            PAM entry point for setting user credentials (that is, to actually
            establish the authenticated user's credentials to the service provider)
        */
        public int pam_sm_setcred([MarshalAs(UnmanagedType.LPStruct)] pam_handle pamh, int flags, int argc, [MarshalAs(UnmanagedType.LPTStr)] string argv)
        {
            Console.Write("pam_sm_setcred");
            return PAM_Vars.PAM_IGNORE;
        }

        /* PAM entry point for authentication token (password) changes */
        public int pam_sm_chauthtok([MarshalAs(UnmanagedType.LPStruct)] pam_handle pamh, int flags, int argc, [MarshalAs(UnmanagedType.LPTStr)] string argv)
        {
            Console.Write("pam_sm_chauthtok");
            return PAM_Vars.PAM_IGNORE;
        }

        /* PAM entry point for session creation */
        public int pam_sm_open_session([MarshalAs(UnmanagedType.LPStruct)] pam_handle pamh, int flags, int argc, [MarshalAs(UnmanagedType.LPTStr)] string argv)
        {
            Console.Write("pam_sm_open_session init");
            return PAM_Vars.PAM_IGNORE;
        }

        /* PAM entry point for session cleanup */
        int pam_sm_close_session([MarshalAs(UnmanagedType.LPStruct)] pam_handle pamh, int flags, int argc, [MarshalAs(UnmanagedType.LPTStr)] string argv)
        {
            Console.Write("pam_sm_close_session init");
            return PAM_Vars.PAM_IGNORE;
        }
    }
}
