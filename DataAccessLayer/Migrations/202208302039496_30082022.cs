namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _30082022 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageContent", c => c.String());
            DropColumn("dbo.Messages", "MessageContact");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "MessageContact", c => c.String());
            DropColumn("dbo.Messages", "MessageContent");
        }
    }
}
