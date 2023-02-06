using LdapLoginExample.Model;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LdapLoginExample
{
    class LdapAuthrntication
    {
        private readonly DirectoryEntry _directoryEntry;

        private readonly string _username;

        private readonly string _password;

        private readonly string _domainPath;

        private readonly string _ldapPath;

        private readonly string _domainAndUsername;

        public LdapAuthrntication(string domainPath, string username, string password)
        {
            _username = username;
            _password = password;
            _domainPath = domainPath;
            _ldapPath = $"LDAP://{domainPath}";
            _domainAndUsername = $"{domainPath}\\{username}";

            _directoryEntry = new DirectoryEntry(_ldapPath, _domainAndUsername, password);

        }

        public bool IsAuthenticated()
        {
            DirectorySearcher search = new DirectorySearcher(_directoryEntry);
            search.Filter = $"(&(objectClass=user)(objectCategory=Person)(samaccountname={_username}))";
            search.PropertiesToLoad.Add("cn");
            SearchResult results = search.FindOne();
            ResultPropertyValueCollection values = results.Properties["cn"];
            if (values[0].Equals(_username))
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// 使用 AD 搜尋 group member (不好用)        
        /// </summary>
        /// <param name="group"></param>
        /// <returns>SearchResult</returns>
        public SearchResult SearchGroupMember(string group)
        {
            DirectorySearcher search = new DirectorySearcher(_directoryEntry);
            search.Filter = $"(&(objectClass=group)(cn={group}))";
            search.PropertiesToLoad.Add("member");
            search.PropertiesToLoad.Add("memberOf");
            SearchResult results = search.FindOne();
            return results;
            // 使用方式範例
            // var results = ldapAuthrntication.SearchGroupMember(textBoxGroup.Text);
            // foreach (string propertyName in results.Properties.PropertyNames)
            // {
            //    ResultPropertyValueCollection values = results.Properties[propertyName];
            //    textBox1.Text = textBox1.Text + $"{propertyName}:{Environment.NewLine}";
            //    foreach (var value in values)
            //    {
            //        textBox1.Text = textBox1.Text + $" {value}{Environment.NewLine}";
            //    }
            // }
        }

        /// <summary>
        /// 使用 Principal 方式搜尋 group member
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns>Member List in Group</returns>
        public IEnumerable<string> SearchGroupMemberPrincipal(string ou, string groupName)
        {
            IEnumerable<string> members = new List<string>();
            PrincipalContext context = (_username.Equals("")) ? new PrincipalContext(ContextType.Domain, _domainPath, ou) : new PrincipalContext(ContextType.Domain, _domainPath, ou, _username, _password);

            //context.ValidateCredentials(_username, _password);
            GroupPrincipal groups = new GroupPrincipal(context);
            groups.SamAccountName = groupName;

            using (PrincipalSearcher searcher = new PrincipalSearcher(groups))
            {
                if (searcher.FindOne() is GroupPrincipal group)
                {
                    members = group.Members.Select(c => c.SamAccountName + ":" + c.DisplayName).OrderBy(c => c);
                }
            }

            return members;
        }


        public Dictionary<string, List<EmployeeModel>> Export900GroupMember(string ou, string groupName)
        {

            Dictionary<string, List<EmployeeModel>> models = new Dictionary<string, List<EmployeeModel>>();
            PrincipalContext context = (_username.Equals("")) ? new PrincipalContext(ContextType.Domain, _domainPath, ou) : new PrincipalContext(ContextType.Domain, _domainPath, ou, _username, _password);
            List<SubDepartMentModel> subDepartMentModels = new List<SubDepartMentModel> {
                new SubDepartMentModel { SubDepartMentCode = "MAN", SubDepartMentName = "資訊處管理階級" },
                new SubDepartMentModel { SubDepartMentCode = "NSD", SubDepartMentName = "系統網路組" },
                new SubDepartMentModel { SubDepartMentCode = "OCC1", SubDepartMentName = "連線管理一組" },
                new SubDepartMentModel { SubDepartMentCode = "OCC2", SubDepartMentName = "連線管理二組" },
                new SubDepartMentModel { SubDepartMentCode = "DCD", SubDepartMentName = "資安管制組" },
                new SubDepartMentModel { SubDepartMentCode = "SPD", SubDepartMentName = "系統規劃組" },
                new SubDepartMentModel { SubDepartMentCode = "SPP", SubDepartMentName = "系統處理組" },
                new SubDepartMentModel { SubDepartMentCode = "ADP1", SubDepartMentName = "設計分析一組" },
                new SubDepartMentModel { SubDepartMentCode = "ADP2", SubDepartMentName = "設計分析二組" },
                new SubDepartMentModel { SubDepartMentCode = "ADP3", SubDepartMentName = "設計分析三組" },
                new SubDepartMentModel { SubDepartMentCode = "ADP4", SubDepartMentName = "設計分析四組" },
                new SubDepartMentModel { SubDepartMentCode = "ADP5", SubDepartMentName = "設計分析五組" },
                new SubDepartMentModel { SubDepartMentCode = "ADP6", SubDepartMentName = "設計分析六組" },
                new SubDepartMentModel { SubDepartMentCode = "ADP7", SubDepartMentName = "設計分析七組" },
                new SubDepartMentModel { SubDepartMentCode = "ADP8", SubDepartMentName = "設計分析八組" },
                new SubDepartMentModel { SubDepartMentCode = "ADP9", SubDepartMentName = "設計分析九組" },
                new SubDepartMentModel { SubDepartMentCode = "ADPA", SubDepartMentName = "設計分析十組" },
                new SubDepartMentModel { SubDepartMentCode = "ADPB", SubDepartMentName = "設計分析十一組" },
                new SubDepartMentModel { SubDepartMentCode = "ADPC", SubDepartMentName = "設計分析十二組" },
            };



            foreach (var subDepartMentModel in subDepartMentModels)
            {
                GroupPrincipal groups = new GroupPrincipal(context)
                {
                    SamAccountName = subDepartMentModel.SubDepartMentCode
                };
                using (PrincipalSearcher searcher = new PrincipalSearcher(groups))
                {
                    if (searcher.FindOne() is GroupPrincipal group)
                    {                        
                        models.Add(
                            subDepartMentModel.SubDepartMentName,
                            group.Members.Select(c =>
                            {
                                EmployeeModel model = new EmployeeModel()
                                {
                                    EmployeeId = c.SamAccountName,
                                    Name = c.DisplayName,
                                    DepartMentName = "",
                                    DepartMentCode = "",
                                    SubDepartMentCode = subDepartMentModel.SubDepartMentCode,
                                    SubDepartMentName = group.DisplayName
                                };
                                return model;
                            }).OrderBy(c => c.EmployeeId).ToList()
                        );
                    }
                }
            }
            return models;
        }



        public SearchResultCollection SearchGroupMemberByPerson(string group)
        {
            DirectorySearcher search = new DirectorySearcher(_directoryEntry);
            search.Filter = $"(&(objectClass=user)(objectCategory=Person)(memberOf=CN={group},OU=authap,OU=zGroup,DC=megabank,DC=megafg,DC=net))";
            search.PropertiesToLoad.Add("cn");
            search.PropertiesToLoad.Add("mail");
            SearchResultCollection results = search.FindAll();
            return results;
        }

        public SearchResult SearchSubGroupMember(string group)
        {
            DirectorySearcher search = new DirectorySearcher(_directoryEntry);
            search.Filter = $"(&(objectClass=group)(cn={group}))";
            search.PropertiesToLoad.Add("member");
            search.PropertiesToLoad.Add("memberOf");
            SearchResult results = search.FindOne();
            return results;
        }

        public bool IsAuthenticatedPrincipal(string ou)
        {
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _domainPath, ou))
            {
                bool exist = context.ValidateCredentials(_username, _password);
                return exist;
            }
        }



        public void Close()
        {
            _directoryEntry.Close();
        }
    }
}
