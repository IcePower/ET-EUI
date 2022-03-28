namespace ET
{
    public static class RoleInfoSystem
    {
        public static void FromMessage(this RoleInfo self, RoleInfoProto roleInfoProto)
        {
            self.Name = roleInfoProto.Name;
            self.State = roleInfoProto.State;
            self.AccountId = roleInfoProto.AccountId;
            self.CreateTime = roleInfoProto.CreateTime;
            self.ServerId = roleInfoProto.ServerId;
            self.LastLoginTime = roleInfoProto.LastLoginTime;
        }

        public static RoleInfoProto ToMessage(this RoleInfo self)
        {
            return new RoleInfoProto()
            {
                Id = self.Id,
                Name = self.Name,
                State = self.State,
                AccountId = self.AccountId,
                CreateTime = self.CreateTime,
                LastLoginTime = self.LastLoginTime
            };
        }
    }
}