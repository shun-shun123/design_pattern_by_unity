using Facade.SubSystems;

namespace Facade
{

    public class Study
    {
        private HeadPhone _headPhone;
        private YouTube _youTube;
        private Computer _computer;
        
        public Study(HeadPhone headPhone, YouTube youtube, Computer computer)
        {
            _headPhone = headPhone;
            _youTube = youtube;
            _computer = computer;
        }

        public void StartProgramming()
        {
            _headPhone.PowerOn();
            _computer.PowerOn();
            _headPhone.Connect();
            _youTube.SearchVideoList();
            _youTube.SelectVideo();
            _computer.OpenIDE();
        }
    }
}