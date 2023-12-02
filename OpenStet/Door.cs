namespace TheLockedDoor
{
    public class Door
    {
        public int _Passcode { get; private set; }
        public bool _Open { get; private set; } = true;
        public bool _Unlocked { get; private set; } = false;
        public Door(int passcode)
        {
            _Passcode = passcode;
        }
        public void RequestOpen()   // Request Door Open
        {
            if (!_Open && _Unlocked)
            {
                _Open = false;
            }
            else Prompt.InvalidRequest();
        }
        public void RequestClose()   // Request Door Close
        {
            if (_Open)
            {
                _Open = false;
                return;
            }
            else Prompt.InvalidRequest();
        }
        public void RequestLock()   // Request Door Lock -- Set Passcode
        {
            if (!_Open && _Unlocked)
            {
                _Passcode = Prompt.SetPasscode();
                _Unlocked = false;
                return;
            }
            else Prompt.InvalidRequest();
        }
        public void RequestUnlock()   // Request Door Unlock -- Enter Passcode
        {
            if (!_Open && !_Unlocked)
            {
                int enterPasscode = Prompt.EnterPasscode();
                if (_Passcode == enterPasscode)
                {
                    _Passcode = enterPasscode;
                    _Unlocked = true;
                    return;
                }
            }
            else Prompt.InvalidRequest();
        }
    }
}