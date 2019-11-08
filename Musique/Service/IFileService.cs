using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musique.Entity;

namespace Musique.Service
{
    interface IFileService
    {
        Task<bool> SaveMemberCredentialToFile(MemberCredential memberCredential);

        Task<MemberCredential> ReadMemberCredentialFromFile();
    }
}
