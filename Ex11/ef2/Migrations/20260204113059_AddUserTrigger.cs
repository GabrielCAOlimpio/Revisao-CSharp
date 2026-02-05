using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef2.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTrigger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql
            (@"
                CREATE TRIGGER trg_userLog
                ON users
                AFTER INSERT,DELETE, UPDATE
                AS
                BEGIN

                    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
                    INSERT INTO userLogs(Username,Email,CreatedAt,State)
                    SELECT i.Username, i.Email, i.CreatedAt, 'INSERTED'
                    FROM inserted i

                    IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS (SELECT * FROM inserted)
                    INSERT INTO userLogs(Username, Email, CreatedAt, State)
                    SELECT d.Username, d.Email, d.CreatedAt, 'DETELETED'
                    FROM deleted d 

                    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
                    INSERT INTO userLogs(Username, Email, CreatedAt, State)
                    SELECT i.Username, i.Email, i.CreatedAt, 'UPDATED'
                    FROM inserted i 

                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER IF EXISTS TRG_User_Log");
        }
    }
}
