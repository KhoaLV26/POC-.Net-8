using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rookies.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class AddBlogCreatedTimestamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBorrowingRequests_BookBorrowingRequestDetails_BookBorrowingRequestDetailId",
                table: "BookBorrowingRequests");

            migrationBuilder.DropIndex(
                name: "IX_BookBorrowingRequests_BookBorrowingRequestDetailId",
                table: "BookBorrowingRequests");

            migrationBuilder.DropColumn(
                name: "BookBorrowingRequestDetailId",
                table: "BookBorrowingRequests");

            migrationBuilder.AddColumn<Guid>(
                name: "BookBorrowingRequestId",
                table: "BookBorrowingRequestDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrowingRequestDetails_BookBorrowingRequestId",
                table: "BookBorrowingRequestDetails",
                column: "BookBorrowingRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookBorrowingRequestDetails_BookBorrowingRequests_BookBorrowingRequestId",
                table: "BookBorrowingRequestDetails",
                column: "BookBorrowingRequestId",
                principalTable: "BookBorrowingRequests",
                principalColumn: "BookBorrowingRequestId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBorrowingRequestDetails_BookBorrowingRequests_BookBorrowingRequestId",
                table: "BookBorrowingRequestDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookBorrowingRequestDetails_BookBorrowingRequestId",
                table: "BookBorrowingRequestDetails");

            migrationBuilder.DropColumn(
                name: "BookBorrowingRequestId",
                table: "BookBorrowingRequestDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "BookBorrowingRequestDetailId",
                table: "BookBorrowingRequests",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrowingRequests_BookBorrowingRequestDetailId",
                table: "BookBorrowingRequests",
                column: "BookBorrowingRequestDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookBorrowingRequests_BookBorrowingRequestDetails_BookBorrowingRequestDetailId",
                table: "BookBorrowingRequests",
                column: "BookBorrowingRequestDetailId",
                principalTable: "BookBorrowingRequestDetails",
                principalColumn: "BookBorrowingRequestDetailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
