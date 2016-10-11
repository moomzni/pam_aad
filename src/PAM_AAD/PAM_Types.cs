namespace PAM_Types
{
    public struct pam_handle { };
    public class PAM_Vars
    {
        public const int __LINUX_PAM__ = 1;
        public const int __LINUX_PAM_MINOR__ = 0;
        public const int PAM_SUCCESS = 0;	                /* Successful function return */
        public const int PAM_OPEN_ERR = 1;                 /* dlopen() failure when dynamically */
        public const int PAM_SYMBOL_ERR = 2;	            /* Symbol not found */
        public const int PAM_SERVICE_ERR = 3;	            /* Error in service module */
        public const int PAM_SYSTEM_ERR = 4;               /* System error */
        public const int PAM_BUF_ERR = 5;  	            /* Memory buffer error */
        public const int PAM_PERM_DENIED = 6;	            /* Permission denied */
        public const int PAM_AUTH_ERR = 7;                 /* Authentication failure */
        public const int PAM_CRED_INSUFFICIENT = 8;        /* Can not access authentication data */
        public const int PAM_AUTHINFO_UNAVAIL = 9;         /* Underlying authentication service */
        public const int PAM_USER_UNKNOWN = 10;	        /* User not known to the underlying */
        public const int PAM_MAXTRIES = 11;	            /* An authentication service has */
        public const int PAM_NEW_AUTHTOK_REQD = 12;	    /* New authentication token required. */
        public const int PAM_ACCT_EXPIRED = 13;	        /* User account has expired */
        public const int PAM_SESSION_ERR = 14;	            /* Can not make/remove an entry for */
        public const int PAM_CRED_UNAVAIL = 15;	        /* Underlying authentication service */
        public const int PAM_CRED_EXPIRED = 16;    	    /* User credentials expired */
        public const int PAM_CRED_ERR = 17;        	    /* Failure setting user credentials */
        public const int PAM_NO_MODULE_DATA = 18;  	    /* No module specific data is present */
        public const int PAM_CONV_ERR = 19;        	    /* Conversation error */
        public const int PAM_AUTHTOK_ERR = 20;     	    /* Authentication token manipulation error */
        public const int PAM_AUTHTOK_RECOVERY_ERR = 21;    /* Authentication information */
        public const int PAM_AUTHTOK_LOCK_BUSY = 22;       /* Authentication token lock busy */
        public const int PAM_AUTHTOK_DISABLE_AGING = 23;   /* Authentication token aging disabled */
        public const int PAM_TRY_AGAIN = 24;           	/* Preliminary check by password service */
        public const int PAM_IGNORE = 25;              	/* Ignore underlying account module */
        public const int PAM_ABORT = 26;                   /* Critical error (?module fail now request) */
        public const int PAM_AUTHTOK_EXPIRED = 27;         /* user's authentication token has expired */
        public const int PAM_MODULE_UNKNOWN = 28;          /* module is not known */
        public const int PAM_BAD_ITEM = 29;                /* Bad item passed to pam_*_item() */
        public const int PAM_CONV_AGAIN = 30;
        public const int PAM_INCOMPLETE = 31;
        public const int _PAM_RETURN_VALUES = 32;          /* this is the number of return values */
        /*
        public const int PAM_SILENT = 0x8000U;
        public const int PAM_DISALLOW_NULL_AUTHTOK = 0x0001U;
        public const int PAM_ESTABLISH_CRED = 0x0002U;
        public const int PAM_DELETE_CRED = 0x0004U;
        public const int PAM_REINITIALIZE_CRED = 0x0008U;
        public const int PAM_REFRESH_CRED = 0x0010U;
        public const int PAM_CHANGE_EXPIRED_AUTHTOK = 0x0020U; // */
        public const int PAM_SERVICE = 1;                  /* The service name */
        public const int PAM_USER = 2;                 	/* The user name */
        public const int PAM_TTY = 3;                      /* The tty name */
        public const int PAM_RHOST = 4;                	/* The remote host name */
        public const int PAM_CONV = 5;                 	/* The pam_conv structure */
        public const int PAM_AUTHTOK = 6;                  /* The authentication token (password) */
        public const int PAM_OLDAUTHTOK = 7;               /* The old authentication token */
        public const int PAM_RUSER = 8;                	/* The remote user name */
        public const int PAM_USER_PROMPT = 9;              /* the prompt for getting a username */
        public const int PAM_FAIL_DELAY = 10;
        public const int PAM_XDISPLAY = 11;                /* X display name */
        public const int PAM_XAUTHDATA = 12;               /* X server authentication data */
        public const int PAM_AUTHTOK_TYPE = 13;            /* The type for pam_get_authtok */
        /*
        public const int PAM_GNUC_PREREQ(maj, min) = 0;
        public const int PAM_FORMAT(params);
        public const int PAM_NONNULL(params);
        public const int PAM_DATA_SILENT = 0x40000000;     /* used to suppress messages... 
        public const int HAVE_PAM_FAIL_DELAY; // */
        public const int PAM_PROMPT_ECHO_OFF = 1;
        public const int PAM_PROMPT_ECHO_ON = 2;
        public const int PAM_ERROR_MSG = 3;
        public const int PAM_TEXT_INFO = 4;
        public const int PAM_RADIO_TYPE = 5;               /* yes/no/maybe conditionals */
        public const int PAM_BINARY_PROMPT = 7;
        public const int PAM_MAX_NUM_MSG = 32;
        public const int PAM_MAX_MSG_SIZE = 512;
        public const int PAM_MAX_RESP_SIZE = 512;
    }
}
