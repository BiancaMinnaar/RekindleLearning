using System;
using BaseBonsai.DataContracts;
using RekindleLearing.Interface.Repository;

namespace RekindleLearing.Root.Repository
{
    public class ProjectBaseRepository : BaseRepository
    {
        protected IMasterRepository _MasterRepo;
        public string[] Errors { get; set; }
        public Action<string[]> OnError { get; set; }

        public ProjectBaseRepository(IMasterRepository masterRepository)
        {
            _MasterRepo = masterRepository;
        }
    }
}

