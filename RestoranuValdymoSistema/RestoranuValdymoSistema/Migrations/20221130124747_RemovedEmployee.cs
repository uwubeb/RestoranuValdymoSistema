using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoranuValdymoSistema.Migrations
{
    public partial class RemovedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("03cb6ebd-cc9b-4628-9ec6-18ec75614fea"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("03fe4aad-db6f-4a1d-a6c8-c0e67852301c"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0702681d-dbdf-40a3-95fa-bcd4c6069c06"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("07e6202c-d1de-425a-a43c-0a4a3e83bb41"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("086fc4d9-4757-4e78-a601-fd843700a17a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0e960484-1447-482e-837c-a1f04772c266"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("10c7bd6a-8a69-4edc-9793-c93f36d408db"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("11129887-01df-423e-9519-f415f7cb4fdf"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("13b98608-adf7-4238-87ab-fce4dc5e8867"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("13ee8105-e709-4672-9ffa-75d2149195df"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1a477b7d-37cd-41e1-a824-b53009b390dd"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1c174f65-a11b-4c7d-b5d6-bd36cdba11e4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1c7abd8f-d4b2-4fff-9707-4d62a628b32f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1f7268ca-a92f-45b0-8844-15a85cecc2a7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1ff2729b-486b-4179-b36c-48e538ef637b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("20677516-d8d9-43bc-8bd5-a64faffbcf0a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("21b6c74c-bc4b-44a9-969e-0980d2cde108"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("21c0cb2d-47d1-450f-8fba-d866ce320c6e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2464acb6-9ff2-428f-9fd7-c340e60e852d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("25ed3691-4419-463a-858e-6df02726cc73"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("27f34e2e-4ce9-4fc3-9019-8daf45de07ef"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("28ffbac7-97a7-4d37-ab6c-92ce1b641548"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2932d2ee-5461-4421-8d60-5ff63f4e889e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2ae4b50f-60bd-4b1b-80fc-104e0ac5a820"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2c1cc232-aa5f-4348-9cfe-305864466337"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2df44ab0-82d8-4da1-b7b4-a357a51ddc49"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2e297a80-631e-4c1c-8dca-25acf465969f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2e854f28-fe8f-495f-b255-4a946f560385"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("301e27c8-7fec-4e6f-870e-c47134443cf6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("31db2e01-e9d0-46c4-afe6-9092675ed0d3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("32223c70-4fc9-4054-8cc1-c2f16fbd2c72"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("32e2f823-6562-4703-b921-461856ca9e16"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("343dd623-4d5f-44be-8352-0bd7b6169315"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("36313ea7-1753-4e23-bd7e-6901a54d2f11"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("36d6d1f2-08b2-4566-9455-9ca8de158b99"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("37fc0e79-aac8-4970-8298-9420c9a2d1ba"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("39173d80-e792-4282-afc6-b099d9ad70f6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("3a666a63-1f68-4423-bf56-51cae0eed741"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("3c09eab7-7054-45e0-9da8-b02484f62c41"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("3c3b0cb8-3d3b-4d73-b794-ecdf81cc1aa4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("40d12b66-fd83-43a7-8414-40aef237ef2d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("41508bc6-c3da-4bab-9d41-61cb2228a200"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("41675706-af01-4d5f-b82d-767be81d99c6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("41dcb38b-d003-4773-b33b-b4f3d8a887e2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4344a895-50c0-49be-9889-f2d8b1bf2efa"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4378a9ec-7a81-4823-90cb-b7fe74bcc7ef"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4498f246-2144-4c2d-84c2-d23672f03886"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("478b0567-ed8a-4793-8664-d3e1c33cfe35"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4aaaea2b-7a58-422e-a4b6-b5e1a9877efa"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4b8e3d10-6643-4dad-9414-5616250c9aca"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4ba3eead-a06a-4311-b31a-96f0d1cecabc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4d0907b6-4e1e-4e69-aa34-81f261698a00"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4de28089-8113-47cb-9924-7e1ddeb848aa"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4eb36dcc-ef07-48bd-b5a3-bb7041f36ad4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4f1509d7-2320-4c73-83f1-328ac7ac7388"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5037f20c-e3e6-459e-bb6e-9909406e0d88"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("508beaa8-8113-41e3-b355-8d15bbc85ccd"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("51637630-4a26-4a08-ae48-3fe7ed172951"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("52baf472-e61e-4e82-ae8c-d509ab77aa85"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("52ddaf88-58a2-4998-8639-982a48387826"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("531aeb23-2d87-4e8f-86bf-962bb5d0210f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5363a3e3-8568-4ef7-bb79-7a2245d17377"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("542b658e-5f0f-4b50-ac2b-6ee6b17abc68"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("558bd28b-9ca9-45a1-bcf6-ff05bcb184d0"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("559123d4-c40b-4ad6-9303-fe0e2a31e09d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("56485eb4-05b3-460c-92da-f2bd3a05f006"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("56a1530f-1103-4468-8ebf-0e0bb0951b2f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("57f5be52-5d92-4c80-b283-c071732d74ec"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5860b7b3-c1cf-4144-9cc8-e3e9e8c7b888"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("586b2a25-3dc4-45d9-a419-1a84f83134c9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("59803779-b88f-446c-b77b-4fbb08bdf334"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5c5226de-4b4e-4ef9-a9db-b559e879e660"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5db80010-1147-419c-b55c-bc5b6586a7a8"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5e27cfbc-a35f-444f-b32f-0cb79001e79d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5ee57bc9-d9c4-4ef0-a064-5af42a7896cb"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5fc81e32-aca1-4d65-9e3f-26be4f5ee3ec"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5ffd2825-1c91-4066-b514-f66e6c3f4378"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6008fc25-811b-4710-ae52-782fa685005f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6179532d-1424-4819-a6d5-271b0c45f99e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("619ea6d4-c642-4c5b-94a1-6894e4e8442c"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("639a3978-736d-42f3-a004-fcaa61d565b0"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("643ffd49-383f-40de-a838-1d1c976b8606"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("65625d08-647c-4ae9-a8f2-733aa2a7ba79"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("66eb0b0a-cf4f-46c1-9a88-4e9d886f96fa"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("698115ef-239e-4a22-ad04-ae894c75871d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6b35a4ed-9c07-49a8-b28c-eccd31e6e3dd"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6c1cac1b-ce1b-4f32-8dcf-12076861f870"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6cf0f2a7-9205-4dbc-91f3-be0d8f234b3c"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6cf9eb9a-5630-48be-8408-7c7c4f629414"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6d7365dd-c61a-46ca-b81b-66da1f1087a1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("703b0ad9-61c8-46bf-91d4-55d4e7e46145"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("709bd13e-cb00-4386-a483-4208546ab5df"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("71311fd3-a0fe-4734-afe1-8327c3e05b69"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("71d70155-0e88-4b1e-836f-99f416351027"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("75231cfe-188d-4ad0-9ca1-74d2bfc94f75"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("75e8a257-e10d-4feb-8762-b1679fce4e6b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("79818237-c65b-4cb0-8b79-b3422fbdebf8"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7ae9bb01-42e5-43c1-b497-8a7865448b18"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7bfe9ba4-ffc8-4ed1-b6eb-ed9e2e26c7e5"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7cf955ac-ba3a-42ef-a044-71f14dd1ef2e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7d7fdd85-a424-4301-a4f5-3a1a25c1c742"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7efda8e2-2073-4784-875b-421350ec57e7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7f1ff2da-ac3f-4898-a2cf-d6babbd4d6a9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("82435ca1-f449-4ac3-8664-2bbd90715143"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("829163cc-dfd4-4a31-82a9-0a8e52a1374a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("842039c4-9c0e-405b-9814-205032a8093a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("844087c5-9e88-4835-8814-e75d0eb8a5c7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("84da4c88-cbab-44c7-9ab5-40ba6aba15f1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("855cf1c5-1bb1-48d7-8e25-a9f96b6bb6e7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("87d4704f-03a9-4414-b24e-9dc1728cb093"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8bfce13f-02a4-43f4-81d0-666bc67e3eab"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8c617a5e-efd7-47bb-81a3-2b0e58ed466e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8d952523-4756-4c5f-8535-a9c9ea293ca4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8e08cd87-197c-4f1f-b338-07c60463b2d7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("954557e5-3ab2-414b-89f3-2e77ad39e11d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("95dd1ffa-004f-46ff-af92-fda43c75bebb"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("97b6eb53-0ed6-4d34-b951-3661ab9a0ea4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9bc222b6-133f-4b9e-9201-6d6228f9cc5e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9ce99e15-3d61-49a6-833e-1ddff666c906"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a12a0d93-a9c6-4214-9801-0155f1d0fd5a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a3418ac3-dfed-4d94-ac6f-30869e3481b1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a459f3bf-43d9-457e-b72d-309e41f564ad"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a495f541-4694-49d1-93bf-37a0cfbb8190"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a4d79d40-4185-44b1-b522-d46e284e9bc5"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a71842cb-0713-4652-b785-429a592b3908"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("aadb61a3-cf74-4132-b70e-106565e43201"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("aaf69997-43ae-430f-aea3-0e385a89cc97"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ac986693-8e34-43e5-953b-1ec27c29e3d3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ad196360-9f9e-492b-b20d-b4b2b2115a40"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b200efd8-f62d-4079-ba80-b5f167e9cd86"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b4aa6167-9e7a-4ee0-8a14-9d8b665775fc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b50dea5a-3b78-482b-9bfc-28cf7ef0e37c"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b5fe6c02-0545-473a-91a6-b1e4615e2713"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b73fa064-1aa4-4f0b-a0d4-5ca1f182b6a7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("bda45469-c6db-40d0-b47d-fdd35ed6adc4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("bf5b798f-0535-4eed-ab77-63b4c372f222"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c02a7993-5d60-4216-a8f4-980bbf24c871"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c0c661d4-2db5-450f-b750-9c188a80d500"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c1e44d88-bf77-42d1-b616-77a0fdd5c8dc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c1f4d945-29c2-47d5-83f5-8ad084f0d460"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c270d137-c04a-483a-bafa-13ad56a3aec6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c2c350d2-9e08-4b15-b6c6-10c2dc85ac6d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c360220d-2e4e-4c5a-a835-3f63b6bfb353"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c3a83815-e35b-4ce8-9a23-bfdb5e0175ef"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c4978320-3cbc-4673-9eb6-c16f67793514"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c51e1382-676e-4875-9406-1ee02f2d10ca"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c74b74ef-9149-4e15-9907-f19bcac655f6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c78e5cfc-88ab-4a88-8a7f-6b9d9b6a83e2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c870e73d-c8f3-42ef-b2cb-90dbf98a6524"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ca1a9225-7470-423e-9107-f1583cc545d4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ca1aec3c-9de8-4f12-8e65-cda88c4bd2f2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cd2d3997-6306-4d4e-b627-2ab82b8bb65c"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ce25c9fa-3576-49fd-afbd-2f236bdcd103"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ceaaa2e0-d65d-4357-bfc7-819c0aab07e9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cecea595-ff89-4306-8f34-b05b026390d3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cee64a34-11c1-4d92-b3fd-8f87712c0d81"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cef347ac-3446-48c6-83bb-cdd16e7666c0"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d0d1b64e-3eab-4097-895e-629df4b6b7ad"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d2bf079d-fe4e-46f8-9808-720a5bffe797"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d3036932-1ef5-4960-bbc7-4aa12a00ef02"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d30d4901-ad26-40de-a7d6-387e2131e306"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d348e8a5-fd89-4fb9-a37d-90d8695515da"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d51632fd-0678-4cd9-81a5-c0dccfd3faa1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d58b6017-6ee5-4c5f-8df0-d28e59514b66"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d5fc98b6-a32e-4e94-bdcc-5c264f672557"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d7761500-728b-492e-be6c-586a8a0b3bc7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("dad31eda-228f-424a-8bef-aada656c27a7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("dbd750a7-9595-4cf6-9133-b3fe4f214a46"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("dde89134-100b-49e9-9d77-55c90c5f8fe9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("dfa13824-8bc7-450d-b1b1-87f51161a7cf"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e02ec0fd-3043-4452-aa58-de7c973ccacc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e0638ccf-bb55-4a75-8bc7-b84f3ad3d050"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e3c0249e-1515-4d76-b401-757a50ee9f85"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e45b0389-2b16-4f2f-bf8d-6f5184067a4a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e475335c-95da-412d-981c-034f9c0d1bfc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e58b2f09-9fab-40b4-b152-2cfdb8def9d6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e68facb8-9ee7-4ea6-a04f-16281916e94a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e8049823-6188-4453-9415-fcb274b32c50"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("eb3ac607-7b80-4ad2-97a5-867e62dc3c98"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("eb62450f-dc92-464b-b8d6-c7ddb81b9b39"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("eee3481f-b387-4fef-aea6-404d8d25c306"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("efc90c60-3ec0-4bd6-b64e-2b88d95e1d98"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f16de81f-d5de-4920-b671-3d264167cb5a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f1acac30-3b53-48bd-a8fb-766b85de79c3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f1ce1b8a-8525-4f08-83a6-d48bbfa1a075"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f34a2764-70cd-4432-a43d-ef3e482963d9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f3929ce7-899e-4525-a7ba-dea541ac90de"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f3ba676d-d49c-42c8-9eda-4126462616f8"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f4e7a586-1e42-4b38-ab2a-16bac56b4adf"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f5168fed-f465-406f-9dfc-fd617e39f998"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f6cace5e-f85d-4695-8d9e-d4c442a2f4da"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f88bef2e-1302-4717-bbe5-056d8147dc17"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f8cf4b84-b275-45f3-a92d-03bf840de83d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f924ddca-ad72-40f4-9e7b-49f08f15d272"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fb080973-7288-4712-a8ed-2db193801807"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fbc10af7-f632-4681-8d80-1f9289f89e33"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fbd16226-f039-49a9-8e0d-f4b7b401da74"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fc3d5c14-9c9f-4d1b-a650-c795e73b3371"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fda9fbd1-4dd9-4afe-bc47-deb121ea1fd9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ff819bd8-c8d0-4697-a5c6-49019cb818aa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ded39bf-43f3-42dd-b8ff-eed70e3ef3c9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("01377514-28ca-43e1-aa83-518fa09b564d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("044987e9-740f-452e-a5b6-b8627043408f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0da985ec-8521-4450-91aa-38020708febf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("11b275d2-04b9-4b10-bae9-d148507e2500"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("18a223ba-7aa7-4797-8d06-99bdfc18e095"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2420631d-50b2-4897-bd00-4fbc423dff29"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2e71e22f-1797-4243-b18c-7b0c341dca00"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3232f40a-d468-4fc5-9c64-60d6c02c4f72"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3626c1f0-9e47-44a7-a9e9-19c57aef98a9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("38cd985d-281d-4b97-8c76-02c744d93921"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("41dce256-e942-474e-981c-f3aaa850bf26"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("44fce4b8-c92e-4333-a41f-a8a9967c12db"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("522e8e31-b04c-4817-8a59-ce459b7519db"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5456b3b0-c1fc-4df0-aea5-eb32db42eae2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5471e8ad-5d90-4613-bf04-a9fa8fa9c25e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("56968c06-0cb7-41f0-a7b3-98a05d9031bd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("60277dd4-806a-4372-8ed5-5a0d6c531e60"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("69b9d672-ae37-4744-b60f-0770a093bac6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6aafd901-1ec2-4f93-922a-1d6b0a66597d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e8cbad5-5d5b-4bbb-a79c-fe12755ab2e0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8428159b-2477-401a-ba3f-e81f56d93092"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8693aaae-c426-4581-ba2c-84f161ba0857"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8c2654c3-d143-456c-a4fd-1da684494948"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8d2538b0-b153-441b-af40-2f163bd58dc9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ef699ce-b0c4-42be-87b9-0316bb9ef9de"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("90289f32-0926-481a-8f66-10f2c1e44ee3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("90aa33c9-4568-43d7-91e1-a46943362cf5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("96d6bafe-a501-48a1-9941-20c6dc37dfd8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("97e96552-a91d-4762-a6f9-fc58dcd572cb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a2596700-f588-4180-b254-b0d55087aac1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a4fa77e8-aa2b-4739-a9a1-6b23f37a60fb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a6ba5355-f9b5-4ad2-a9f8-791987a8e502"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a716f01f-cd23-4858-a543-6074521088ad"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b476e99b-a109-4b3f-b12f-a80f695c8bf3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("badd3334-11c4-49c8-ae42-7d50b4623b9d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bdf8b66e-9f87-4661-8586-db2913a0f6d3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c318b8a2-96be-416b-9b5f-dab8a15777ff"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c5beb321-7f9d-4c1e-afd4-068e16921f37"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cc4062ab-bb77-4c18-828b-79a9b0bf52be"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d088537e-afa3-4c09-a363-64e336f85566"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("debf05d5-2bda-4ff1-b35d-387cbb6f3217"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e1e6c1f0-a10e-4a62-8028-ff57d58d658d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e351de89-7efc-4e4e-b6a3-c4be60f55b59"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e5bf3077-49e3-4ded-ba89-2e21c31de1e2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6386b84-2a55-4306-bfbf-8165431988d3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e74591ba-43a0-4578-959b-46e2f71e44b8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ef8a1d2f-8843-492a-9020-2f61f9c49b30"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("feaf3dd4-2c2f-4003-86b8-a4e2682bbf1c"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("02336dc2-d874-432e-a769-43c849479893"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("3a242560-9358-49ec-9fab-c494274a3881"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("4532e989-562f-4cc7-8032-24ce119ec592"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "RestaurantUser",
                columns: table => new
                {
                    RestaurantsId = table.Column<Guid>(type: "uuid", nullable: false),
                    UsersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantUser", x => new { x.RestaurantsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RestaurantUser_Restaurants_RestaurantsId",
                        column: x => x.RestaurantsId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "CreationDate", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78"), "96346 Leffler Garden, Jaquanberg, Guatemala", new DateTime(2022, 11, 30, 12, 47, 47, 537, DateTimeKind.Utc).AddTicks(6555), "Elvis99@gmail.com", "Ankunding, Zemlak and Schoen", "1-363-419-0946 x012" },
                    { new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0"), "9143 Jacobson Springs, South Forestbury, Guyana", new DateTime(2022, 11, 30, 12, 47, 47, 537, DateTimeKind.Utc).AddTicks(7050), "Boris.Cassin@gmail.com", "Schinner, Ernser and Bradtke", "687-800-8284" },
                    { new Guid("43f5c2c9-4c7b-4bb6-b698-203056470fc2"), "11893 Icie Shore, O'Harahaven, Peru", new DateTime(2022, 11, 30, 12, 47, 47, 537, DateTimeKind.Utc).AddTicks(7361), "Matteo31@hotmail.com", "Lynch - Haag", "1-610-701-0220 x94891" },
                    { new Guid("cd67ee4b-bef1-4694-85fb-22e63f199f3b"), "522 Ferry Burg, Lazaroville, Monaco", new DateTime(2022, 11, 30, 12, 47, 47, 537, DateTimeKind.Utc).AddTicks(7680), "Myrtie_Schmidt@gmail.com", "Rodriguez Inc", "(451) 498-0387 x3884" },
                    { new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7"), "1602 Fidel Village, Port Marisol, Niue", new DateTime(2022, 11, 30, 12, 47, 47, 537, DateTimeKind.Utc).AddTicks(5577), "Rene_Torphy@gmail.com", "Brown and Sons", "(679) 701-3717" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreationDate", "Description", "Item", "Price", "Quantity", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("04abf890-152a-4449-a9bd-712d1f5511ac"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2556), "The Football Is Good For Training And Recreational Purposes", "Tasty Wooden Mouse", 53.542415632653199m, 3, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("06145600-782e-438c-ba61-6385413eb5d6"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2747), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Granite Pizza", 54.287827598530756m, 9, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("06ffe47c-1e7e-40b7-ad5f-b4d6cce2a83d"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1929), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomic Cotton Computer", 87.655121670875329m, 7, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("158093b1-e570-4565-9d56-8cb0c3a8925b"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2134), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Soft Hat", 73.539013501042066m, 3, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("15fb602f-0fdf-46a0-b9ef-eccf9957266a"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2787), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Rubber Bacon", 19.998994586057497m, 2, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("1a8396fa-8e42-496d-9a57-4116da111dde"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2700), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Metal Sausages", 97.578948019807693m, 4, new Guid("cd67ee4b-bef1-4694-85fb-22e63f199f3b") },
                    { new Guid("1ff07180-6fb8-48ac-ba4e-bfc057c68b2b"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2368), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Plastic Pizza", 75.490387418535715m, 3, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("2c348380-5c54-40b0-8a68-ac3510b4407e"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1904), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Sleek Metal Soap", 59.941903518020116m, 9, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("2f0e64dd-34a8-4c7d-ae94-4764d4eba0a3"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2177), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Wooden Mouse", 35.192317857496579m, 9, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("313aa27d-e03e-439a-a08f-cc0163b265a4"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2155), "The Football Is Good For Training And Recreational Purposes", "Licensed Fresh Fish", 75.949547890084615m, 3, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("3666f334-d391-4658-be13-413d89c27735"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2198), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Metal Fish", 72.304783756986637m, 8, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("3e60df1f-d972-4bf4-bccd-833d62d9e2a7"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2597), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Cotton Salad", 69.043895312139703m, 1, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2388), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Concrete Chair", 78.457719934386055m, 1, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("52ef881a-1432-4ce8-9d79-5c95587621a5"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2513), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Frozen Mouse", 77.827932043852231m, 1, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("567f427e-691b-45ff-8db7-25eb24df7b05"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1952), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Steel Cheese", 17.727801994759537m, 10, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("597c29dd-2951-44a1-a810-179be6cceb22"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1769), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Plastic Fish", 65.701310062176172m, 9, new Guid("cd67ee4b-bef1-4694-85fb-22e63f199f3b") },
                    { new Guid("5ce311dd-a06f-4c09-9eb3-5d38332277a8"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2843), "The Football Is Good For Training And Recreational Purposes", "Generic Cotton Car", 57.230385630964534m, 10, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("5d6b8ddc-72b9-4035-8525-cae292999fab"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2113), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Steel Table", 36.332572167428437m, 8, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("70a9617e-e509-45e8-aa9d-ac82904de345"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2638), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Rubber Pants", 72.223463362186927m, 9, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("70d29078-472a-4e29-8848-8f64efe87b40"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2908), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Metal Towels", 39.707028698971006m, 8, new Guid("43f5c2c9-4c7b-4bb6-b698-203056470fc2") },
                    { new Guid("76f3e60a-a48c-405e-ae04-272ca1108f89"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2000), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Soft Pants", 58.877750568966229m, 2, new Guid("43f5c2c9-4c7b-4bb6-b698-203056470fc2") },
                    { new Guid("821a6361-22e5-4fbe-b69f-9009059e2c18"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2328), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Concrete Chips", 82.975748718704896m, 1, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("8280aeed-66cc-4bd9-845c-ba1d3a5b65bf"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2240), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Fresh Sausages", 25.387679749349026m, 2, new Guid("43f5c2c9-4c7b-4bb6-b698-203056470fc2") },
                    { new Guid("82d6cb7d-6431-46ad-a6a1-51950a3e1ead"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1379), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Cotton Keyboard", 31.361360390373232m, 2, new Guid("cd67ee4b-bef1-4694-85fb-22e63f199f3b") },
                    { new Guid("8572847b-13b4-4b4b-af77-bf04fb7285c2"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2409), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Concrete Cheese", 98.701421517739765m, 2, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("866c1a50-e425-4a65-ac1f-018bcbd0a04d"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1851), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Metal Fish", 5.0115892868543008m, 1, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("8cb4f6cb-e201-4b89-afd6-8f4db610b3a3"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2535), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Fresh Bacon", 22.833833344203331m, 2, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2447), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Rustic Plastic Pants", 9.7346689397164945m, 2, new Guid("cd67ee4b-bef1-4694-85fb-22e63f199f3b") },
                    { new Guid("980c4628-5eba-4838-93f4-f963dd04689b"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1823), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Metal Sausages", 4.829817586964842m, 2, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("a18508dc-5005-4a95-8b27-d7ce1031b058"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2656), "The Football Is Good For Training And Recreational Purposes", "Awesome Concrete Gloves", 50.318400277904428m, 5, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("aa261eba-e3f3-455a-8970-b494649ecb9d"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2467), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Metal Pants", 98.090623055161252m, 9, new Guid("43f5c2c9-4c7b-4bb6-b698-203056470fc2") },
                    { new Guid("ad4d6137-e7c2-4827-a80b-def70a8b1477"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1878), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Granite Chips", 49.365517168941643m, 1, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("b0555db0-3dfc-4065-b190-3c3a380d2a94"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2864), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Frozen Hat", 94.946991149311399m, 3, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("b0af6292-4408-4503-b6d7-c946b9f816cc"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1974), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Frozen Towels", 81.291850958155375m, 1, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("b44be778-6c57-45bd-ac38-68823b44ca84"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2575), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Metal Hat", 41.025619855162513m, 7, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("b5b9f980-c210-445a-b3a1-227dc2e39050"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2307), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Fresh Hat", 55.789858830529207m, 1, new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78") },
                    { new Guid("bb970028-da82-4d56-8622-bfc1c0427d38"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2070), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Metal Shirt", 92.606178554057233m, 2, new Guid("43f5c2c9-4c7b-4bb6-b698-203056470fc2") },
                    { new Guid("bf639bf8-cca4-4383-a41c-d7eda77290e0"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2806), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Metal Gloves", 63.956836149076342m, 7, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("c58543e8-b13a-4fd9-a8a2-dcfd304ed019"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2617), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Rubber Tuna", 63.717927022705735m, 8, new Guid("43f5c2c9-4c7b-4bb6-b698-203056470fc2") },
                    { new Guid("cb1f1bfc-e929-476a-aa0d-31c997f6098b"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2348), "The Football Is Good For Training And Recreational Purposes", "Small Soft Tuna", 12.652859094856705m, 1, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("cb7912af-366d-421f-9b67-f609faa7c9ca"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2428), "The Football Is Good For Training And Recreational Purposes", "Intelligent Cotton Cheese", 52.078607128038358m, 8, new Guid("cd67ee4b-bef1-4694-85fb-22e63f199f3b") },
                    { new Guid("cca046ab-610f-425a-b8e3-5eeb51a2def3"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2021), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Plastic Salad", 90.959913988113367m, 5, new Guid("43f5c2c9-4c7b-4bb6-b698-203056470fc2") },
                    { new Guid("d22e335b-1b50-4885-b430-2c8ade2ca7f7"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2721), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Practical Fresh Shoes", 92.77639623208738m, 6, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("d8c4b9b5-d52b-437d-86df-7567c501213f"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1731), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Plastic Chicken", 9.8111542252875625m, 8, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("dadb8690-a38d-4118-ada4-c5a0c889c29e"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2825), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Fresh Pizza", 6.1255486738521406m, 8, new Guid("cd67ee4b-bef1-4694-85fb-22e63f199f3b") },
                    { new Guid("e106bc08-0ad1-4305-ab96-91468ac8f043"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(1691), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Concrete Chair", 1.74855786177728215m, 1, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("e660f2f0-cc6d-4498-bb05-b11b3d896422"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2219), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Granite Pants", 53.595881986709215m, 6, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") },
                    { new Guid("f2d88e14-5e40-4458-9242-4397d9f3f0c6"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2765), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Wooden Chips", 68.362399984785499m, 7, new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7") },
                    { new Guid("fb45da69-7ff0-4c23-9403-710993b9f3c2"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2093), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Wooden Tuna", 81.165952471627792m, 4, new Guid("cd67ee4b-bef1-4694-85fb-22e63f199f3b") },
                    { new Guid("fdc6cda7-34cc-4cf3-a20a-c608384bc077"), new DateTime(2022, 11, 30, 12, 47, 47, 539, DateTimeKind.Utc).AddTicks(2929), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Rubber Keyboard", 45.89308294509214m, 10, new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0") }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "CreationDate", "OrderId", "Text" },
                values: new object[,]
                {
                    { new Guid("003a8fbf-65c1-4a39-8852-0c0839455114"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6849), new Guid("e106bc08-0ad1-4305-ab96-91468ac8f043"), "Incidunt placeat qui minima quia quos rem earum ut." },
                    { new Guid("00ba85dd-0e21-42ed-9125-6a2fddef81f1"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6774), new Guid("980c4628-5eba-4838-93f4-f963dd04689b"), "Nihil minus iste illum nostrum aliquam." },
                    { new Guid("0407dec9-a7ff-4b6d-8e42-2c008a1094d9"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9363), new Guid("e660f2f0-cc6d-4498-bb05-b11b3d896422"), "Omnis voluptatem doloremque ducimus error." },
                    { new Guid("04d95d5d-25cc-4256-b968-ab8568ead73d"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8838), new Guid("158093b1-e570-4565-9d56-8cb0c3a8925b"), "Optio fugiat magni." },
                    { new Guid("0617e649-272b-43d5-878a-4aeb8644714b"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6592), new Guid("fb45da69-7ff0-4c23-9403-710993b9f3c2"), "Asperiores velit voluptatum quia illo voluptatibus veritatis illo porro." },
                    { new Guid("06f75ade-6fef-44c0-9b7c-44556cc01663"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9444), new Guid("a18508dc-5005-4a95-8b27-d7ce1031b058"), "Sed quo explicabo facilis inventore maiores numquam quia voluptatem." },
                    { new Guid("08d2fed9-90db-4167-9fa1-e816c8378db1"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7229), new Guid("b0555db0-3dfc-4065-b190-3c3a380d2a94"), "Sit tempora consequatur quasi ut asperiores tenetur." },
                    { new Guid("09d0bcac-9c6f-4e96-9219-5c631f31c5c1"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5827), new Guid("3e60df1f-d972-4bf4-bccd-833d62d9e2a7"), "Error odio architecto ut perferendis voluptatum error vel." },
                    { new Guid("0b43b123-d07d-4215-9dd7-9121659c1d97"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8705), new Guid("2c348380-5c54-40b0-8a68-ac3510b4407e"), "Et sit praesentium." },
                    { new Guid("0b50e7cd-426a-4292-84e2-4bb226eceaa0"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6730), new Guid("70a9617e-e509-45e8-aa9d-ac82904de345"), "Ratione sed maxime." },
                    { new Guid("0c6ea067-79cf-4417-bd50-e936a7e7d37f"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8612), new Guid("bb970028-da82-4d56-8622-bfc1c0427d38"), "Eum aperiam aut rerum optio reprehenderit consequatur laudantium." },
                    { new Guid("0cb986a3-e48b-46a8-9910-d95b0dd39c11"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6971), new Guid("1ff07180-6fb8-48ac-ba4e-bfc057c68b2b"), "Vel optio dolore eveniet est." },
                    { new Guid("0ce3e743-736f-486b-a4ca-2c25825d1a45"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(584), new Guid("cb1f1bfc-e929-476a-aa0d-31c997f6098b"), "Debitis laudantium velit." },
                    { new Guid("0f60a5ae-39a5-4ee8-99a9-46448b5e10c1"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6068), new Guid("c58543e8-b13a-4fd9-a8a2-dcfd304ed019"), "Natus facere officiis quod dolores qui ut alias atque voluptate." },
                    { new Guid("10e1c80b-6ee0-439f-aad4-168fa42bd88d"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6540), new Guid("c58543e8-b13a-4fd9-a8a2-dcfd304ed019"), "Quisquam maxime vel quasi non officia laudantium eaque repellendus pariatur." },
                    { new Guid("116aa54e-1c01-4cac-b8ed-c4d454abf8b7"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9243), new Guid("d22e335b-1b50-4885-b430-2c8ade2ca7f7"), "Ut consequatur voluptatem reiciendis similique dolores aperiam." },
                    { new Guid("11a5d25c-e210-4742-8ffc-1a4187578df0"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7830), new Guid("06ffe47c-1e7e-40b7-ad5f-b4d6cce2a83d"), "Sed voluptatem asperiores eius ea." },
                    { new Guid("12895cb4-0cd3-47e7-9ff5-29266f00d4db"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8771), new Guid("dadb8690-a38d-4118-ada4-c5a0c889c29e"), "Sit corporis dicta voluptas perspiciatis." },
                    { new Guid("144ebec6-e067-4cf4-aca5-f57924773828"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(22), new Guid("bb970028-da82-4d56-8622-bfc1c0427d38"), "Quo quo doloribus necessitatibus quibusdam ullam quas dolorem aliquam." },
                    { new Guid("15070c5c-7e45-4989-b570-c979ba51ab05"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9493), new Guid("dadb8690-a38d-4118-ada4-c5a0c889c29e"), "Expedita alias laborum quisquam dolorem expedita est excepturi blanditiis et." },
                    { new Guid("160c31c8-a34d-4a17-8bbd-a987fe334dce"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5854), new Guid("980c4628-5eba-4838-93f4-f963dd04689b"), "Excepturi eum et saepe quod earum facere." },
                    { new Guid("1707dadc-5ed8-4afe-8ccd-46d5ea1598b0"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6572), new Guid("cb1f1bfc-e929-476a-aa0d-31c997f6098b"), "Et voluptas ut aspernatur id." },
                    { new Guid("194296c6-46c0-4793-b655-ca2d95356cee"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(405), new Guid("1a8396fa-8e42-496d-9a57-4116da111dde"), "Error qui doloribus qui ducimus autem repudiandae dolores sequi tempore." },
                    { new Guid("1950769f-d6f3-44b6-a111-026cf4d4c1c1"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(168), new Guid("3666f334-d391-4658-be13-413d89c27735"), "Eaque sint et." },
                    { new Guid("1e35881d-5ffa-4250-9675-7aa2d677bb20"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6795), new Guid("3e60df1f-d972-4bf4-bccd-833d62d9e2a7"), "Aut blanditiis iure adipisci odio aut et quo quia." },
                    { new Guid("2038e19a-b335-4020-8a44-82d6df1e1979"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8903), new Guid("a18508dc-5005-4a95-8b27-d7ce1031b058"), "Et reprehenderit sed repellat dolores mollitia laudantium corrupti soluta eos." },
                    { new Guid("20a0c1fa-0e16-4828-9eac-2596d092d6eb"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8040), new Guid("5d6b8ddc-72b9-4035-8525-cae292999fab"), "In quis nulla rerum commodi impedit voluptatem rerum molestias autem." },
                    { new Guid("2266c43f-57e0-49cd-abcf-3f3849229aa7"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8248), new Guid("5d6b8ddc-72b9-4035-8525-cae292999fab"), "Porro modi iste autem consectetur modi." },
                    { new Guid("2624b7cd-5611-4a4a-be75-732a24426dcb"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5904), new Guid("5d6b8ddc-72b9-4035-8525-cae292999fab"), "Et quos sit." },
                    { new Guid("265d68cc-2e5b-424c-a949-6fe9ae70f439"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5606), new Guid("dadb8690-a38d-4118-ada4-c5a0c889c29e"), "Asperiores maiores quia dolores voluptatem." },
                    { new Guid("276a0d1d-0d5b-481a-acfa-d06ebb4c39a1"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7975), new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"), "Saepe velit velit soluta sit quas dolorem delectus ratione consectetur." },
                    { new Guid("28362c0d-134d-4153-8a82-c5ce9f4e1a31"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9736), new Guid("c58543e8-b13a-4fd9-a8a2-dcfd304ed019"), "Velit aut repudiandae." },
                    { new Guid("2ad25f61-7eb6-44a0-97f8-baa859258487"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9574), new Guid("b0555db0-3dfc-4065-b190-3c3a380d2a94"), "Maiores commodi enim quia autem aliquid ut rerum magni eos." },
                    { new Guid("2b12517d-332c-4c12-8f21-7f772fbb76de"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9309), new Guid("8cb4f6cb-e201-4b89-afd6-8f4db610b3a3"), "Commodi qui quaerat aut possimus cupiditate quia ut modi voluptates." },
                    { new Guid("2b874ea2-d462-4925-b67f-5b4d00d44f1e"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(390), new Guid("597c29dd-2951-44a1-a810-179be6cceb22"), "Aut quasi amet." },
                    { new Guid("2c67617b-4aa8-461a-858b-aaecc88e8546"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8373), new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"), "Laborum repellendus illo dolores dolorem quia praesentium sint et." },
                    { new Guid("2d4c3d7f-5f0c-4f50-8a61-d65a52df70e5"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9469), new Guid("3666f334-d391-4658-be13-413d89c27735"), "Est dolorem magnam ullam optio ab laboriosam nobis." },
                    { new Guid("30abbb80-3981-449b-b122-c08454e3a4dd"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5576), new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), "Perferendis voluptatem optio occaecati sed placeat officiis occaecati." },
                    { new Guid("31f842b0-650e-4bb5-a4e2-7684da630104"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6699), new Guid("a18508dc-5005-4a95-8b27-d7ce1031b058"), "Minima maxime voluptas distinctio et suscipit cum est et fuga." },
                    { new Guid("323be76f-838f-4e40-be56-c967154d5f42"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(540), new Guid("cb7912af-366d-421f-9b67-f609faa7c9ca"), "Ratione et consectetur accusantium mollitia modi debitis." },
                    { new Guid("32ff76fd-28c3-43e1-a5cf-33072092b4c9"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(496), new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), "Non consectetur beatae facilis." },
                    { new Guid("33f08d31-8a5c-4a3c-8d12-0b29731f660b"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7526), new Guid("313aa27d-e03e-439a-a08f-cc0163b265a4"), "Sunt veniam commodi et est maxime saepe." },
                    { new Guid("35548a93-581d-4974-8ddb-8b110163662f"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8456), new Guid("567f427e-691b-45ff-8db7-25eb24df7b05"), "Fugiat corporis repellat aliquid eius officia." },
                    { new Guid("3832fa3f-99ec-4259-8c89-8c88b9ca8e81"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5971), new Guid("ad4d6137-e7c2-4827-a80b-def70a8b1477"), "Et aut officia et corrupti incidunt corrupti et id quisquam." },
                    { new Guid("38620b09-13e7-455e-b9de-152045e2f390"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6827), new Guid("cb7912af-366d-421f-9b67-f609faa7c9ca"), "Necessitatibus saepe perspiciatis est amet." },
                    { new Guid("38cf06f0-45a2-4fad-8fdd-78633f970d54"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6927), new Guid("1ff07180-6fb8-48ac-ba4e-bfc057c68b2b"), "Reprehenderit quibusdam ipsum nostrum recusandae vel error." },
                    { new Guid("39dff73a-82fe-41e1-a643-d11f58b5a954"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5793), new Guid("82d6cb7d-6431-46ad-a6a1-51950a3e1ead"), "Fugit unde ipsa doloremque labore rerum veniam harum ea." },
                    { new Guid("3cf418b6-5e6d-4924-8e8a-dbb2f46e1373"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8638), new Guid("8cb4f6cb-e201-4b89-afd6-8f4db610b3a3"), "Illum aliquid ut non possimus." },
                    { new Guid("3e4f3718-dafc-4d95-9b4c-ccb75eba295b"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5883), new Guid("158093b1-e570-4565-9d56-8cb0c3a8925b"), "Praesentium incidunt aut est." },
                    { new Guid("3ecdecdd-288d-409b-abf5-db1e6bb8118c"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9193), new Guid("3666f334-d391-4658-be13-413d89c27735"), "Ut et rerum numquam dignissimos vel et doloribus." },
                    { new Guid("424eb234-5efa-4067-b940-775c55c3dfae"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7363), new Guid("8cb4f6cb-e201-4b89-afd6-8f4db610b3a3"), "Dolore quia harum molestias." },
                    { new Guid("432663a9-7515-4592-b5f6-a114a1dda0fd"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8353), new Guid("567f427e-691b-45ff-8db7-25eb24df7b05"), "Ut illo omnis quibusdam eum rerum." },
                    { new Guid("4544ddc6-5c63-41c4-b5f8-a49675b845d2"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6027), new Guid("3666f334-d391-4658-be13-413d89c27735"), "Praesentium deserunt temporibus quod sapiente est voluptatibus." },
                    { new Guid("45c10acf-2232-4bd7-b470-db5cb972b6f9"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9957), new Guid("d8c4b9b5-d52b-437d-86df-7567c501213f"), "Sed non saepe sequi exercitationem autem perferendis." },
                    { new Guid("460a58e2-5e9b-4e1e-aad5-526fb2c4ee7d"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7407), new Guid("70d29078-472a-4e29-8848-8f64efe87b40"), "Porro tempore voluptate aliquid." },
                    { new Guid("461861ce-0421-4387-bf0f-7ece167fa510"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7575), new Guid("fdc6cda7-34cc-4cf3-a20a-c608384bc077"), "Et quisquam corporis accusantium nesciunt qui." },
                    { new Guid("47c23fbb-db76-46de-b385-020debd65b0b"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7595), new Guid("c58543e8-b13a-4fd9-a8a2-dcfd304ed019"), "Vel quaerat odio ut et dolore." },
                    { new Guid("48daf059-b6b3-4c84-8a56-c989ce09af00"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6900), new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), "Consequatur rem fugiat veritatis omnis est quis ut." },
                    { new Guid("49553070-c7f4-4b6d-8c21-91fb54288c8a"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(183), new Guid("b0af6292-4408-4503-b6d7-c946b9f816cc"), "Quia blanditiis rerum similique unde cum non blanditiis aut fugit." },
                    { new Guid("4970c9af-9268-42dc-930a-8619f104c512"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9009), new Guid("8cb4f6cb-e201-4b89-afd6-8f4db610b3a3"), "Molestiae exercitationem quia cum quo." },
                    { new Guid("4a8c79cf-1507-40f3-aaa2-52a2ee6747bf"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8269), new Guid("b0af6292-4408-4503-b6d7-c946b9f816cc"), "Minima totam cupiditate ut." },
                    { new Guid("4d63d9f6-59e8-47c4-9c55-75b59471bcac"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5434), new Guid("15fb602f-0fdf-46a0-b9ef-eccf9957266a"), "Eum omnis dolor non perspiciatis voluptatum repellendus." },
                    { new Guid("4d737fad-bb71-48b6-98f1-207a7a342fd8"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(473), new Guid("c58543e8-b13a-4fd9-a8a2-dcfd304ed019"), "Eaque tempore maxime ipsum ea molestiae impedit ea." },
                    { new Guid("4e5fc228-08c1-4460-9a8b-6440befc2de0"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5556), new Guid("e660f2f0-cc6d-4498-bb05-b11b3d896422"), "Tempora in dolorem." },
                    { new Guid("4e7fd29c-84e7-48dc-8c1d-b8efa0c51cb2"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6952), new Guid("e106bc08-0ad1-4305-ab96-91468ac8f043"), "Aut consequatur ut deleniti." },
                    { new Guid("4f1962ec-c983-49e7-9c6e-2c87e0332a99"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9264), new Guid("8280aeed-66cc-4bd9-845c-ba1d3a5b65bf"), "Recusandae neque quo consequatur voluptatem quasi inventore aut atque ea." },
                    { new Guid("4f5a65e8-e90c-4336-b0a5-d36e9c17fefb"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7681), new Guid("cb1f1bfc-e929-476a-aa0d-31c997f6098b"), "Dolorum quaerat commodi harum repudiandae tempore officiis debitis." },
                    { new Guid("4f9dc522-fe4b-4a32-89b7-11e1573f00ef"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9219), new Guid("ad4d6137-e7c2-4827-a80b-def70a8b1477"), "Sed a maxime ea aliquam dignissimos dignissimos illum." },
                    { new Guid("4fd321bc-e81f-43dc-9a62-8fc987b8c160"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6005), new Guid("b0af6292-4408-4503-b6d7-c946b9f816cc"), "Dolores optio provident omnis." },
                    { new Guid("50b9665f-da0a-48b6-98f9-7b3f7cdf806b"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8399), new Guid("8572847b-13b4-4b4b-af77-bf04fb7285c2"), "Corporis animi consequatur tempore id ut nisi hic tempore quia." },
                    { new Guid("53390bac-83e9-4819-937f-b9bb8718d4a2"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(432), new Guid("5ce311dd-a06f-4c09-9eb3-5d38332277a8"), "Vitae magnam atque quia voluptatem quas doloribus." },
                    { new Guid("54a6688c-2543-4a73-a61b-2f86098528b1"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6221), new Guid("b44be778-6c57-45bd-ac38-68823b44ca84"), "Odit vel perferendis libero libero et." },
                    { new Guid("561afc2d-a705-4d2a-b74b-6dbd9fcc75c1"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7550), new Guid("2f0e64dd-34a8-4c7d-ae94-4764d4eba0a3"), "Autem consequuntur eius explicabo voluptatem optio commodi." },
                    { new Guid("581c1974-1e0e-46eb-9e0d-1d86ed5499a8"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7813), new Guid("1a8396fa-8e42-496d-9a57-4116da111dde"), "Quam consequatur iste." },
                    { new Guid("5903fdb9-8357-4da7-bb5a-b452f46edebb"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6266), new Guid("8cb4f6cb-e201-4b89-afd6-8f4db610b3a3"), "Eligendi cum rerum eos pariatur qui similique." },
                    { new Guid("5abeb873-3da3-48db-9100-ad8f14df604b"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(254), new Guid("3666f334-d391-4658-be13-413d89c27735"), "Voluptatum laboriosam expedita consequatur dolor repudiandae." },
                    { new Guid("5c03759a-4318-47c2-8330-f05543ca1b7b"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6321), new Guid("2f0e64dd-34a8-4c7d-ae94-4764d4eba0a3"), "Rerum qui enim." },
                    { new Guid("5d0686d4-c048-4450-9190-be362b3af103"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5924), new Guid("158093b1-e570-4565-9d56-8cb0c3a8925b"), "Qui repellat nulla itaque." },
                    { new Guid("602092e4-03d6-4fe2-8f89-703f3d5ee1dd"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7638), new Guid("567f427e-691b-45ff-8db7-25eb24df7b05"), "Voluptate a ullam quas." },
                    { new Guid("61902202-1be8-41fb-b50e-56d48fcb7d4a"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7873), new Guid("1ff07180-6fb8-48ac-ba4e-bfc057c68b2b"), "Qui aliquam ipsa velit deserunt cum sed." },
                    { new Guid("62c2e339-fba0-435f-8858-9cc33f58997e"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7657), new Guid("ad4d6137-e7c2-4827-a80b-def70a8b1477"), "Qui dolorem omnis non dolorum ut dolore et." },
                    { new Guid("6426b8d4-41f8-493a-8438-dd9621cb5760"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7185), new Guid("cb7912af-366d-421f-9b67-f609faa7c9ca"), "Qui iure labore minima in unde vitae inventore." },
                    { new Guid("65152aaa-1f80-4077-9993-6c3b3d83e466"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7144), new Guid("5d6b8ddc-72b9-4035-8525-cae292999fab"), "Sequi impedit ut numquam illum inventore." },
                    { new Guid("668e1427-1e26-44a4-babb-ffd993af4a4d"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7939), new Guid("e660f2f0-cc6d-4498-bb05-b11b3d896422"), "Est saepe mollitia id aut exercitationem." },
                    { new Guid("67440499-f15d-4069-8bf7-37e28c09fe48"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6464), new Guid("bb970028-da82-4d56-8622-bfc1c0427d38"), "Ut enim provident earum ducimus quia cum perspiciatis." },
                    { new Guid("67b4b0ff-d111-4424-968c-6f5207752b04"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9600), new Guid("15fb602f-0fdf-46a0-b9ef-eccf9957266a"), "Quo deleniti et ut voluptas dignissimos laborum." },
                    { new Guid("68fda716-51a6-45d3-9cad-541a6fec9883"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8491), new Guid("b44be778-6c57-45bd-ac38-68823b44ca84"), "Vel accusantium saepe atque." },
                    { new Guid("6c5bfc29-222d-486d-a2ca-c1f2336bc90e"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8427), new Guid("b5b9f980-c210-445a-b3a1-227dc2e39050"), "Numquam omnis nulla et modi nihil est occaecati sunt in." },
                    { new Guid("6e7686a8-2671-4965-add0-cbe8fbd5a2b3"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(456), new Guid("5ce311dd-a06f-4c09-9eb3-5d38332277a8"), "Deleniti non voluptas quo." },
                    { new Guid("6ec7829a-eee6-4b28-a9a8-d776862568bf"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8853), new Guid("980c4628-5eba-4838-93f4-f963dd04689b"), "Omnis facere est." },
                    { new Guid("74c90b9d-b180-4944-a5ae-104439d10bbc"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9754), new Guid("5d6b8ddc-72b9-4035-8525-cae292999fab"), "Cum ut qui quo pariatur error soluta quibusdam ab ducimus." },
                    { new Guid("7869a387-7cf1-4f27-91ef-11aed65affa5"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7894), new Guid("82d6cb7d-6431-46ad-a6a1-51950a3e1ead"), "Sint qui facere rerum fugit." },
                    { new Guid("7910000f-bf47-4382-a20d-e036dd175067"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(128), new Guid("cca046ab-610f-425a-b8e3-5eeb51a2def3"), "A quis doloremque quia sit eveniet et omnis rem." },
                    { new Guid("7cb8c59e-8a96-492b-b512-36ff9fae3c8f"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7960), new Guid("bf639bf8-cca4-4383-a41c-d7eda77290e0"), "Quae rerum non." },
                    { new Guid("7de89e11-08cb-4494-a063-f3b0d299206e"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6160), new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"), "Quo dicta id quia in maxime dolorem temporibus inventore dolorum." },
                    { new Guid("7e7636cb-5585-47a5-8f99-d255973314bc"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8207), new Guid("dadb8690-a38d-4118-ada4-c5a0c889c29e"), "Qui deleniti id eum molestiae earum neque necessitatibus." },
                    { new Guid("7fb17b43-4359-4abc-a18b-5ea17802ab30"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9174), new Guid("e106bc08-0ad1-4305-ab96-91468ac8f043"), "Dolorum doloremque nihil non necessitatibus." },
                    { new Guid("801e2afc-856a-43f4-a876-3532edd22a63"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(274), new Guid("cb1f1bfc-e929-476a-aa0d-31c997f6098b"), "Repellendus eius itaque voluptatem libero qui eos." },
                    { new Guid("8326e0cb-ba7d-4731-91e3-7b35546dda32"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6623), new Guid("b0af6292-4408-4503-b6d7-c946b9f816cc"), "Sed omnis omnis." },
                    { new Guid("8446d2ee-f1c7-4bc8-8cb0-dfe35c7c822a"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6051), new Guid("fdc6cda7-34cc-4cf3-a20a-c608384bc077"), "Officia ea sint." },
                    { new Guid("86eee2ab-db98-4944-a6c2-47a53bfc0937"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5212), new Guid("76f3e60a-a48c-405e-ae04-272ca1108f89"), "Doloribus error velit aut illo optio ducimus rem placeat." },
                    { new Guid("87480c56-39da-440d-8877-94792916c825"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7755), new Guid("15fb602f-0fdf-46a0-b9ef-eccf9957266a"), "Et quos quia cum." },
                    { new Guid("888a25b5-d1a5-465f-a097-2624efcd6da3"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8231), new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), "Nostrum explicabo in." },
                    { new Guid("89918f28-68d6-4dc4-acdf-b97adb15e96d"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7256), new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"), "Iusto magni praesentium." },
                    { new Guid("89b3af88-bf82-4fb4-9914-14172709e8cf"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8992), new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"), "Quia rem pariatur." },
                    { new Guid("8bc8b783-b9aa-4953-bab2-2a7396cbaf70"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9075), new Guid("a18508dc-5005-4a95-8b27-d7ce1031b058"), "Dignissimos enim autem nihil doloribus rerum sunt animi quo." },
                    { new Guid("8bee465f-f8a1-4eb6-ab2b-d67d06ab0db3"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8554), new Guid("2c348380-5c54-40b0-8a68-ac3510b4407e"), "Dolor architecto vel et." },
                    { new Guid("918d7e89-4c96-42a7-a986-3ff4c17fc558"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7166), new Guid("70a9617e-e509-45e8-aa9d-ac82904de345"), "Nihil quibusdam et quo odit." },
                    { new Guid("933187ae-ba90-4a01-894a-75e3865d9de4"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8135), new Guid("e106bc08-0ad1-4305-ab96-91468ac8f043"), "Ut corrupti ea labore dolor est numquam voluptatem." },
                    { new Guid("93839d74-1dc0-4de8-90eb-58dce5e590b2"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8955), new Guid("313aa27d-e03e-439a-a08f-cc0163b265a4"), "Fuga aut impedit." },
                    { new Guid("95b6ade4-bf47-4159-8a0a-cf908301a4d7"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8476), new Guid("15fb602f-0fdf-46a0-b9ef-eccf9957266a"), "Eum accusantium nesciunt." },
                    { new Guid("975fd29e-97a9-4b1b-ad27-745b16633087"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6516), new Guid("04abf890-152a-4449-a9bd-712d1f5511ac"), "Sed aut itaque voluptatem velit neque." },
                    { new Guid("9808e0e2-2cb1-4c85-a672-ba36811efc20"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9809), new Guid("567f427e-691b-45ff-8db7-25eb24df7b05"), "Ratione ducimus et sunt cupiditate adipisci amet rerum." },
                    { new Guid("99892dcc-60ed-47c5-a565-b10add03ace2"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5734), new Guid("dadb8690-a38d-4118-ada4-c5a0c889c29e"), "Earum esse est in at et." },
                    { new Guid("9a6ecea2-313d-4e83-9938-a80cab3c30d7"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8789), new Guid("866c1a50-e425-4a65-ac1f-018bcbd0a04d"), "Necessitatibus facere corporis illum dolores ea." },
                    { new Guid("9a8bfacd-7d29-47f3-87eb-3d2361a8007c"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9650), new Guid("5ce311dd-a06f-4c09-9eb3-5d38332277a8"), "Quia et ea omnis provident qui neque iste." },
                    { new Guid("9bacf82a-7108-41ad-be19-ec16e14b1040"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8159), new Guid("567f427e-691b-45ff-8db7-25eb24df7b05"), "Atque dignissimos ea eos ut iure enim ut vero." },
                    { new Guid("9be2ad9a-60f7-443f-802e-4677fddec49e"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9548), new Guid("5ce311dd-a06f-4c09-9eb3-5d38332277a8"), "Commodi dolores quia voluptatem veritatis consequuntur sed non non." },
                    { new Guid("9d00437d-6e25-400e-8efc-65e88147e178"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7851), new Guid("52ef881a-1432-4ce8-9d79-5c95587621a5"), "Et sed magni illo est assumenda." },
                    { new Guid("9db52ef1-5010-46ab-8e36-c1102bcfc76f"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8678), new Guid("313aa27d-e03e-439a-a08f-cc0163b265a4"), "Molestiae aut quidem cumque est magni aut nihil reprehenderit provident." },
                    { new Guid("9e852c62-90f8-4e8c-8c4f-c2d140750ff6"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9102), new Guid("82d6cb7d-6431-46ad-a6a1-51950a3e1ead"), "Ullam repellat cumque pariatur ut iure." },
                    { new Guid("9f6a27a1-f57d-4796-ae1d-68a2d2349655"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(226), new Guid("cca046ab-610f-425a-b8e3-5eeb51a2def3"), "Quasi rerum quia unde numquam ab error nulla quo voluptatum." },
                    { new Guid("a01ecf88-8320-43e5-82d6-3e34fe7afefc"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6359), new Guid("980c4628-5eba-4838-93f4-f963dd04689b"), "Quae nobis omnis consectetur ad." },
                    { new Guid("a0ad1e79-cbf0-4760-b016-1a86f52329c9"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7007), new Guid("fdc6cda7-34cc-4cf3-a20a-c608384bc077"), "Dolores est iusto quo quae exercitationem quo hic tempora." },
                    { new Guid("a0b79f98-fbc6-491d-a8ba-094e185127df"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7119), new Guid("567f427e-691b-45ff-8db7-25eb24df7b05"), "Exercitationem minus consequatur iure sunt provident consectetur amet." },
                    { new Guid("a1612899-9726-4aa6-a98b-8dd1e8eed6e6"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8311), new Guid("821a6361-22e5-4fbe-b69f-9009059e2c18"), "Perferendis quam aut." },
                    { new Guid("a20fda75-111a-4e3a-927e-ca48acdf617a"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5630), new Guid("f2d88e14-5e40-4458-9242-4397d9f3f0c6"), "Provident quibusdam ipsum dicta minus nobis exercitationem excepturi." },
                    { new Guid("a258e0eb-4c91-4e14-91a5-c3f94da794d3"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7104), new Guid("5ce311dd-a06f-4c09-9eb3-5d38332277a8"), "Voluptatem ea qui." },
                    { new Guid("a451251c-f2d1-48d6-b4fc-d0438f0437b6"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(367), new Guid("3e60df1f-d972-4bf4-bccd-833d62d9e2a7"), "Nam libero qui molestiae quibusdam odit pariatur." },
                    { new Guid("a58e91dd-f59c-4025-af9a-6e10e6e27179"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8287), new Guid("d8c4b9b5-d52b-437d-86df-7567c501213f"), "Ipsam quasi dolorum ea dolores quia perspiciatis." },
                    { new Guid("a5fbfb3c-07cf-43c2-86c9-8dbcdf537834"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7730), new Guid("aa261eba-e3f3-455a-8970-b494649ecb9d"), "Et consequuntur harum et numquam ea voluptates architecto." },
                    { new Guid("a6047def-d002-4a07-9023-3f432b370645"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9622), new Guid("04abf890-152a-4449-a9bd-712d1f5511ac"), "Aut non aut sed dolor vel maiores non voluptatem praesentium." },
                    { new Guid("a7e627fc-bf06-4cd0-a783-4f104c19f24a"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8507), new Guid("76f3e60a-a48c-405e-ae04-272ca1108f89"), "Placeat quasi eum voluptas minus voluptatibus in." },
                    { new Guid("a9184848-4bd1-4693-963d-6a971b86bb9b"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5762), new Guid("b0af6292-4408-4503-b6d7-c946b9f816cc"), "Qui voluptatibus id explicabo illo laborum." },
                    { new Guid("aa5bf881-dab6-4352-9106-9057cba432c6"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7055), new Guid("d22e335b-1b50-4885-b430-2c8ade2ca7f7"), "Doloribus aut quisquam eum beatae ipsa qui." },
                    { new Guid("ab7beacc-05cf-4eef-9b06-087a89331046"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7773), new Guid("158093b1-e570-4565-9d56-8cb0c3a8925b"), "Quia nostrum fuga blanditiis eius." },
                    { new Guid("ac485e73-5666-4db4-a702-0f64f1b5c3d7"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8188), new Guid("cca046ab-610f-425a-b8e3-5eeb51a2def3"), "Dolores et sunt ipsum neque." },
                    { new Guid("ac4af6ce-53ad-4edd-b17e-59177ed5b6d3"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8868), new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), "Excepturi dolores culpa natus similique ea." },
                    { new Guid("ae17c01e-736a-41ed-b230-c6cc82a1f8e2"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5712), new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), "Iusto ducimus iste quis." },
                    { new Guid("b6a73e59-2715-494a-ae76-2d6016387fcb"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9885), new Guid("bb970028-da82-4d56-8622-bfc1c0427d38"), "Amet dolorem error in facilis deserunt enim at." },
                    { new Guid("b8d58bba-bd14-4a1a-af6e-8ade01252c10"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9420), new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), "Illo odio autem cum ab tenetur veniam vel." },
                    { new Guid("b968f51b-e72f-4d58-b189-038249755ac3"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8086), new Guid("3e60df1f-d972-4bf4-bccd-833d62d9e2a7"), "Alias id voluptas sunt nihil totam fuga quia." },
                    { new Guid("b9816381-6ddf-4421-a6a9-6100bf8a5f7c"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8018), new Guid("06ffe47c-1e7e-40b7-ad5f-b4d6cce2a83d"), "Natus consequatur adipisci est ea autem." },
                    { new Guid("ba74b159-f04c-44c3-8bbd-597b29564d5a"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9055), new Guid("8280aeed-66cc-4bd9-845c-ba1d3a5b65bf"), "Ratione nam consequatur saepe unde vero." },
                    { new Guid("bfbb3f6a-3e52-4e01-9b79-7c7b8713c0c4"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6384), new Guid("866c1a50-e425-4a65-ac1f-018bcbd0a04d"), "Tempore porro est occaecati consequatur quis." },
                    { new Guid("c0550279-5e2a-406f-9890-1125ceb0a84b"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9782), new Guid("597c29dd-2951-44a1-a810-179be6cceb22"), "Accusantium nemo iure non necessitatibus sed nulla voluptatem earum aut." },
                    { new Guid("c160708b-aa92-4fb6-b31d-d1805396b242"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8595), new Guid("f2d88e14-5e40-4458-9242-4397d9f3f0c6"), "Consectetur id aut optio." },
                    { new Guid("c3cbf559-b735-46d9-b6f7-be92c08eb42f"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6489), new Guid("fdc6cda7-34cc-4cf3-a20a-c608384bc077"), "Dolore sit facere quas impedit sequi dolores." },
                    { new Guid("c4904074-9910-4dd2-97f3-24e4fa0f50bb"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5510), new Guid("dadb8690-a38d-4118-ada4-c5a0c889c29e"), "Et corporis nam molestias." },
                    { new Guid("c5e3644e-81bf-4486-9cdf-2606a82c2842"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8971), new Guid("b44be778-6c57-45bd-ac38-68823b44ca84"), "Molestiae debitis doloribus quasi modi similique tempore." },
                    { new Guid("c6af3102-c1ec-45aa-ad1f-c467cc311c93"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9978), new Guid("aa261eba-e3f3-455a-8970-b494649ecb9d"), "Facere sunt est omnis labore delectus mollitia aut officia recusandae." },
                    { new Guid("c8a80b13-eabb-4bac-b1e6-409c33d13293"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(68), new Guid("06ffe47c-1e7e-40b7-ad5f-b4d6cce2a83d"), "Totam quia enim." },
                    { new Guid("c988b6b1-a0cf-469e-95c4-44348ca18b91"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6243), new Guid("8572847b-13b4-4b4b-af77-bf04fb7285c2"), "Asperiores vel quisquam est quos vel." },
                    { new Guid("cb6039b8-a6d3-4fe1-a3a1-c8900d0c039e"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7793), new Guid("c58543e8-b13a-4fd9-a8a2-dcfd304ed019"), "Aspernatur consequuntur rerum rerum dolor voluptatem." },
                    { new Guid("cd8b69fd-0c57-4edf-97c3-6d72c87e1371"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9029), new Guid("8572847b-13b4-4b4b-af77-bf04fb7285c2"), "Consectetur corrupti voluptatibus voluptatem vel quisquam quibusdam molestias omnis." },
                    { new Guid("cdef7cf9-43b8-4aab-8d7c-32030a7b6651"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9673), new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"), "Dolorum esse officia quis voluptas eos necessitatibus quia corrupti." },
                    { new Guid("cf815bf9-48e0-44b5-b178-29e8d10eba8f"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9908), new Guid("866c1a50-e425-4a65-ac1f-018bcbd0a04d"), "Quibusdam tempora commodi labore voluptas voluptatem unde enim." },
                    { new Guid("d18ac344-704b-4eae-a493-969f70b986fd"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9859), new Guid("e106bc08-0ad1-4305-ab96-91468ac8f043"), "Asperiores sequi consequuntur architecto deleniti nemo iusto et velit." },
                    { new Guid("d299dd8d-ac0b-4c19-aef9-868ffe511d65"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7208), new Guid("d22e335b-1b50-4885-b430-2c8ade2ca7f7"), "Quia architecto molestiae blanditiis temporibus vel." },
                    { new Guid("d3ddbfae-a2a3-4fdf-a9bf-9ed01e29bbd2"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7322), new Guid("b5b9f980-c210-445a-b3a1-227dc2e39050"), "Qui eum rerum maiores necessitatibus voluptates sint esse." },
                    { new Guid("d5eef13a-779c-4ce1-ba17-3ff9975da50a"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6126), new Guid("2c348380-5c54-40b0-8a68-ac3510b4407e"), "Exercitationem voluptatum maxime sed voluptas ab illum quidem odit." },
                    { new Guid("d9eb377e-a515-4479-8b14-897da7f8f5ef"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7441), new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"), "At explicabo ea at asperiores nihil." },
                    { new Guid("db46a5e0-7367-4db0-ba79-461d57d1c630"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9158), new Guid("06ffe47c-1e7e-40b7-ad5f-b4d6cce2a83d"), "Velit nulla debitis." },
                    { new Guid("db47a52f-bc32-444f-8bbe-6f72278a6d7b"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8658), new Guid("cb1f1bfc-e929-476a-aa0d-31c997f6098b"), "Porro cum ut deserunt doloribus." },
                    { new Guid("dbb07b2b-a2a4-49ce-a782-a656be70adab"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7425), new Guid("82d6cb7d-6431-46ad-a6a1-51950a3e1ead"), "Dolores occaecati quo." },
                    { new Guid("df7a1c37-1e10-43c7-874c-8609725bcff9"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6103), new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"), "Aut ex est animi mollitia." },
                    { new Guid("e19b63f5-dbf7-490d-8756-ce8a395e0950"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8003), new Guid("52ef881a-1432-4ce8-9d79-5c95587621a5"), "Facilis est nihil." },
                    { new Guid("e25f4a2b-5bfd-4b5d-95c9-8267787a6038"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9698), new Guid("821a6361-22e5-4fbe-b69f-9009059e2c18"), "Aut dolor iusto." },
                    { new Guid("e4a4aa4a-24e1-46ab-9849-f93939f1bdc4"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9382), new Guid("b0555db0-3dfc-4065-b190-3c3a380d2a94"), "Quisquam nostrum velit suscipit." },
                    { new Guid("e4fb79be-fb3e-4943-a389-de49a882c079"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7034), new Guid("5d6b8ddc-72b9-4035-8525-cae292999fab"), "Soluta voluptates odio vel doloremque." },
                    { new Guid("e5148de7-5fbf-445b-aedd-212d05dc529b"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(6), new Guid("5ce311dd-a06f-4c09-9eb3-5d38332277a8"), "Qui necessitatibus sunt velit." },
                    { new Guid("e6658d34-58d6-46c3-8f30-f8d3c9a7b85a"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(346), new Guid("15fb602f-0fdf-46a0-b9ef-eccf9957266a"), "Alias nihil delectus qui velit aliquid quidem." },
                    { new Guid("e83e556a-f1e6-4b96-bda2-361f0ace4dc7"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(46), new Guid("980c4628-5eba-4838-93f4-f963dd04689b"), "Odit pariatur culpa modi delectus molestias." },
                    { new Guid("ea3fba12-3c1e-4509-822b-1120e7a3d9db"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6989), new Guid("1ff07180-6fb8-48ac-ba4e-bfc057c68b2b"), "Reprehenderit accusantium consequatur incidunt." },
                    { new Guid("eb21ed06-eba6-4938-b84d-c64650251a73"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7618), new Guid("d22e335b-1b50-4885-b430-2c8ade2ca7f7"), "Qui sunt qui maxime quia magnam." },
                    { new Guid("ebb2a294-5851-4172-b439-dbf1657a1791"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8572), new Guid("8280aeed-66cc-4bd9-845c-ba1d3a5b65bf"), "Voluptas et et asperiores qui dicta earum." },
                    { new Guid("ebb5c37f-c882-4f42-a98f-da95b67fe2ae"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7379), new Guid("cb1f1bfc-e929-476a-aa0d-31c997f6098b"), "Fugit aut unde blanditiis id ad facilis molestiae necessitatibus consequatur." },
                    { new Guid("ee56e575-3d37-4bb0-b67f-390d2023c621"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(562), new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), "Adipisci qui vel vitae et voluptatem maiores." },
                    { new Guid("ef1d7040-2165-4829-9533-9b98de494d6f"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6296), new Guid("3e60df1f-d972-4bf4-bccd-833d62d9e2a7"), "Non dolor rerum omnis aut provident ipsum." },
                    { new Guid("ef484c2e-a8d5-42b5-ac72-cbac98b3bea6"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(209), new Guid("e660f2f0-cc6d-4498-bb05-b11b3d896422"), "Rem qui id illum." },
                    { new Guid("ef9383ff-a9e4-4a75-b896-6e937ea39491"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8887), new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"), "Quas enim quibusdam assumenda." },
                    { new Guid("f09bd9c3-c219-431f-b0c0-0b024888c2ab"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7462), new Guid("fdc6cda7-34cc-4cf3-a20a-c608384bc077"), "Suscipit molestiae quisquam veniam accusantium sunt non sequi harum enim." },
                    { new Guid("f1050e18-81bd-42ed-8ad4-02c011e63fdf"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8809), new Guid("15fb602f-0fdf-46a0-b9ef-eccf9957266a"), "Iusto culpa porro voluptatem ut aliquam occaecati nihil fuga aliquid." },
                    { new Guid("f131f4c4-d420-4b42-935f-664f94503b1d"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6746), new Guid("b5b9f980-c210-445a-b3a1-227dc2e39050"), "Qui a quos tempora rerum totam quidem dolorem." },
                    { new Guid("f1b53489-5f9d-4f86-bfae-5bde9ecaf168"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(296), new Guid("cca046ab-610f-425a-b8e3-5eeb51a2def3"), "Ratione placeat ut harum accusantium unde quod tempore et." },
                    { new Guid("f2e4ef86-684d-491b-a8d4-6c725d355b97"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5534), new Guid("866c1a50-e425-4a65-ac1f-018bcbd0a04d"), "Eaque itaque nisi." },
                    { new Guid("f38e0e78-d513-4a9b-b401-92ac322ab0dc"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8067), new Guid("1ff07180-6fb8-48ac-ba4e-bfc057c68b2b"), "Architecto nihil laborum voluptas sint." },
                    { new Guid("f39a5095-3545-4741-896c-da1a96786ac3"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(8720), new Guid("313aa27d-e03e-439a-a08f-cc0163b265a4"), "Delectus rerum et voluptates minus aut quas quis perspiciatis." },
                    { new Guid("f442504a-b412-4d87-86d8-cc5e3ecbd3f5"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7271), new Guid("597c29dd-2951-44a1-a810-179be6cceb22"), "Et est dolor qui tenetur voluptates laborum voluptas." },
                    { new Guid("f552ade0-6abe-4244-b39e-f8c7037c4a9e"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(83), new Guid("e106bc08-0ad1-4305-ab96-91468ac8f043"), "A laboriosam dolores reprehenderit tenetur." },
                    { new Guid("f68ec5da-654d-4c9d-ae59-d80166c7153e"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6410), new Guid("06ffe47c-1e7e-40b7-ad5f-b4d6cce2a83d"), "Nulla maxime cumque amet minima omnis reiciendis rem." },
                    { new Guid("f7237574-f49b-43ca-b031-b83e1d70347c"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9292), new Guid("8280aeed-66cc-4bd9-845c-ba1d3a5b65bf"), "Sit nam est qui sint." },
                    { new Guid("f7d44b01-6ab7-4192-a17e-04a3def0ab3a"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(5480), new Guid("2f0e64dd-34a8-4c7d-ae94-4764d4eba0a3"), "Eum libero et sunt aspernatur." },
                    { new Guid("f9cabba1-0c36-4541-b9f7-939c37f47299"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9832), new Guid("2c348380-5c54-40b0-8a68-ac3510b4407e"), "Rerum voluptatem voluptas sunt doloribus in non velit iusto." },
                    { new Guid("fa42c808-0979-4724-ac3a-8f6d403ef7fd"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(599), new Guid("5d6b8ddc-72b9-4035-8525-cae292999fab"), "Soluta quis pariatur possimus repudiandae temporibus." },
                    { new Guid("fb07a14e-5f3e-4098-9daa-60ed2f062d51"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(9399), new Guid("8cb4f6cb-e201-4b89-afd6-8f4db610b3a3"), "Impedit amet occaecati ratione suscipit magnam." },
                    { new Guid("fc49ba99-119e-43dc-9eab-d203d74a39b6"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(7349), new Guid("158093b1-e570-4565-9d56-8cb0c3a8925b"), "Est occaecati sit." },
                    { new Guid("fd337ee6-78ae-4a57-8cc6-9a5ffbe39b9e"), new DateTime(2022, 11, 30, 12, 47, 47, 541, DateTimeKind.Utc).AddTicks(154), new Guid("cb1f1bfc-e929-476a-aa0d-31c997f6098b"), "Impedit quia animi." },
                    { new Guid("fdb7ce10-f148-4fb4-8788-0f6283419896"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6340), new Guid("e106bc08-0ad1-4305-ab96-91468ac8f043"), "Consequatur esse tempore et." },
                    { new Guid("fdcf3dbd-5088-443c-a766-68e3dca3bda0"), new DateTime(2022, 11, 30, 12, 47, 47, 540, DateTimeKind.Utc).AddTicks(6667), new Guid("c58543e8-b13a-4fd9-a8a2-dcfd304ed019"), "Quibusdam laudantium odio eaque et nostrum laudantium et nemo voluptas." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantUser_UsersId",
                table: "RestaurantUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantUser");

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("003a8fbf-65c1-4a39-8852-0c0839455114"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("00ba85dd-0e21-42ed-9125-6a2fddef81f1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0407dec9-a7ff-4b6d-8e42-2c008a1094d9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("04d95d5d-25cc-4256-b968-ab8568ead73d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0617e649-272b-43d5-878a-4aeb8644714b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("06f75ade-6fef-44c0-9b7c-44556cc01663"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("08d2fed9-90db-4167-9fa1-e816c8378db1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("09d0bcac-9c6f-4e96-9219-5c631f31c5c1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0b43b123-d07d-4215-9dd7-9121659c1d97"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0b50e7cd-426a-4292-84e2-4bb226eceaa0"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0c6ea067-79cf-4417-bd50-e936a7e7d37f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0cb986a3-e48b-46a8-9910-d95b0dd39c11"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0ce3e743-736f-486b-a4ca-2c25825d1a45"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("0f60a5ae-39a5-4ee8-99a9-46448b5e10c1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("10e1c80b-6ee0-439f-aad4-168fa42bd88d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("116aa54e-1c01-4cac-b8ed-c4d454abf8b7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("11a5d25c-e210-4742-8ffc-1a4187578df0"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("12895cb4-0cd3-47e7-9ff5-29266f00d4db"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("144ebec6-e067-4cf4-aca5-f57924773828"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("15070c5c-7e45-4989-b570-c979ba51ab05"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("160c31c8-a34d-4a17-8bbd-a987fe334dce"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1707dadc-5ed8-4afe-8ccd-46d5ea1598b0"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("194296c6-46c0-4793-b655-ca2d95356cee"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1950769f-d6f3-44b6-a111-026cf4d4c1c1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1e35881d-5ffa-4250-9675-7aa2d677bb20"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2038e19a-b335-4020-8a44-82d6df1e1979"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("20a0c1fa-0e16-4828-9eac-2596d092d6eb"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2266c43f-57e0-49cd-abcf-3f3849229aa7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2624b7cd-5611-4a4a-be75-732a24426dcb"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("265d68cc-2e5b-424c-a949-6fe9ae70f439"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("276a0d1d-0d5b-481a-acfa-d06ebb4c39a1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("28362c0d-134d-4153-8a82-c5ce9f4e1a31"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2ad25f61-7eb6-44a0-97f8-baa859258487"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2b12517d-332c-4c12-8f21-7f772fbb76de"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2b874ea2-d462-4925-b67f-5b4d00d44f1e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2c67617b-4aa8-461a-858b-aaecc88e8546"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2d4c3d7f-5f0c-4f50-8a61-d65a52df70e5"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("30abbb80-3981-449b-b122-c08454e3a4dd"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("31f842b0-650e-4bb5-a4e2-7684da630104"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("323be76f-838f-4e40-be56-c967154d5f42"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("32ff76fd-28c3-43e1-a5cf-33072092b4c9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("33f08d31-8a5c-4a3c-8d12-0b29731f660b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("35548a93-581d-4974-8ddb-8b110163662f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("3832fa3f-99ec-4259-8c89-8c88b9ca8e81"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("38620b09-13e7-455e-b9de-152045e2f390"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("38cf06f0-45a2-4fad-8fdd-78633f970d54"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("39dff73a-82fe-41e1-a643-d11f58b5a954"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("3cf418b6-5e6d-4924-8e8a-dbb2f46e1373"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("3e4f3718-dafc-4d95-9b4c-ccb75eba295b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("3ecdecdd-288d-409b-abf5-db1e6bb8118c"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("424eb234-5efa-4067-b940-775c55c3dfae"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("432663a9-7515-4592-b5f6-a114a1dda0fd"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4544ddc6-5c63-41c4-b5f8-a49675b845d2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("45c10acf-2232-4bd7-b470-db5cb972b6f9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("460a58e2-5e9b-4e1e-aad5-526fb2c4ee7d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("461861ce-0421-4387-bf0f-7ece167fa510"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("47c23fbb-db76-46de-b385-020debd65b0b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("48daf059-b6b3-4c84-8a56-c989ce09af00"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("49553070-c7f4-4b6d-8c21-91fb54288c8a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4970c9af-9268-42dc-930a-8619f104c512"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4a8c79cf-1507-40f3-aaa2-52a2ee6747bf"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4d63d9f6-59e8-47c4-9c55-75b59471bcac"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4d737fad-bb71-48b6-98f1-207a7a342fd8"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4e5fc228-08c1-4460-9a8b-6440befc2de0"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4e7fd29c-84e7-48dc-8c1d-b8efa0c51cb2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4f1962ec-c983-49e7-9c6e-2c87e0332a99"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4f5a65e8-e90c-4336-b0a5-d36e9c17fefb"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4f9dc522-fe4b-4a32-89b7-11e1573f00ef"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4fd321bc-e81f-43dc-9a62-8fc987b8c160"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("50b9665f-da0a-48b6-98f9-7b3f7cdf806b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("53390bac-83e9-4819-937f-b9bb8718d4a2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("54a6688c-2543-4a73-a61b-2f86098528b1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("561afc2d-a705-4d2a-b74b-6dbd9fcc75c1"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("581c1974-1e0e-46eb-9e0d-1d86ed5499a8"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5903fdb9-8357-4da7-bb5a-b452f46edebb"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5abeb873-3da3-48db-9100-ad8f14df604b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5c03759a-4318-47c2-8330-f05543ca1b7b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5d0686d4-c048-4450-9190-be362b3af103"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("602092e4-03d6-4fe2-8f89-703f3d5ee1dd"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("61902202-1be8-41fb-b50e-56d48fcb7d4a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("62c2e339-fba0-435f-8858-9cc33f58997e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6426b8d4-41f8-493a-8438-dd9621cb5760"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("65152aaa-1f80-4077-9993-6c3b3d83e466"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("668e1427-1e26-44a4-babb-ffd993af4a4d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("67440499-f15d-4069-8bf7-37e28c09fe48"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("67b4b0ff-d111-4424-968c-6f5207752b04"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("68fda716-51a6-45d3-9cad-541a6fec9883"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6c5bfc29-222d-486d-a2ca-c1f2336bc90e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6e7686a8-2671-4965-add0-cbe8fbd5a2b3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6ec7829a-eee6-4b28-a9a8-d776862568bf"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("74c90b9d-b180-4944-a5ae-104439d10bbc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7869a387-7cf1-4f27-91ef-11aed65affa5"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7910000f-bf47-4382-a20d-e036dd175067"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7cb8c59e-8a96-492b-b512-36ff9fae3c8f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7de89e11-08cb-4494-a063-f3b0d299206e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7e7636cb-5585-47a5-8f99-d255973314bc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7fb17b43-4359-4abc-a18b-5ea17802ab30"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("801e2afc-856a-43f4-a876-3532edd22a63"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8326e0cb-ba7d-4731-91e3-7b35546dda32"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8446d2ee-f1c7-4bc8-8cb0-dfe35c7c822a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("86eee2ab-db98-4944-a6c2-47a53bfc0937"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("87480c56-39da-440d-8877-94792916c825"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("888a25b5-d1a5-465f-a097-2624efcd6da3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("89918f28-68d6-4dc4-acdf-b97adb15e96d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("89b3af88-bf82-4fb4-9914-14172709e8cf"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8bc8b783-b9aa-4953-bab2-2a7396cbaf70"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8bee465f-f8a1-4eb6-ab2b-d67d06ab0db3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("918d7e89-4c96-42a7-a986-3ff4c17fc558"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("933187ae-ba90-4a01-894a-75e3865d9de4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("93839d74-1dc0-4de8-90eb-58dce5e590b2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("95b6ade4-bf47-4159-8a0a-cf908301a4d7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("975fd29e-97a9-4b1b-ad27-745b16633087"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9808e0e2-2cb1-4c85-a672-ba36811efc20"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("99892dcc-60ed-47c5-a565-b10add03ace2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9a6ecea2-313d-4e83-9938-a80cab3c30d7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9a8bfacd-7d29-47f3-87eb-3d2361a8007c"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9bacf82a-7108-41ad-be19-ec16e14b1040"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9be2ad9a-60f7-443f-802e-4677fddec49e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9d00437d-6e25-400e-8efc-65e88147e178"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9db52ef1-5010-46ab-8e36-c1102bcfc76f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9e852c62-90f8-4e8c-8c4f-c2d140750ff6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9f6a27a1-f57d-4796-ae1d-68a2d2349655"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a01ecf88-8320-43e5-82d6-3e34fe7afefc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a0ad1e79-cbf0-4760-b016-1a86f52329c9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a0b79f98-fbc6-491d-a8ba-094e185127df"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a1612899-9726-4aa6-a98b-8dd1e8eed6e6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a20fda75-111a-4e3a-927e-ca48acdf617a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a258e0eb-4c91-4e14-91a5-c3f94da794d3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a451251c-f2d1-48d6-b4fc-d0438f0437b6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a58e91dd-f59c-4025-af9a-6e10e6e27179"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a5fbfb3c-07cf-43c2-86c9-8dbcdf537834"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a6047def-d002-4a07-9023-3f432b370645"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a7e627fc-bf06-4cd0-a783-4f104c19f24a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a9184848-4bd1-4693-963d-6a971b86bb9b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("aa5bf881-dab6-4352-9106-9057cba432c6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ab7beacc-05cf-4eef-9b06-087a89331046"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ac485e73-5666-4db4-a702-0f64f1b5c3d7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ac4af6ce-53ad-4edd-b17e-59177ed5b6d3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ae17c01e-736a-41ed-b230-c6cc82a1f8e2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b6a73e59-2715-494a-ae76-2d6016387fcb"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b8d58bba-bd14-4a1a-af6e-8ade01252c10"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b968f51b-e72f-4d58-b189-038249755ac3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b9816381-6ddf-4421-a6a9-6100bf8a5f7c"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ba74b159-f04c-44c3-8bbd-597b29564d5a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("bfbb3f6a-3e52-4e01-9b79-7c7b8713c0c4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c0550279-5e2a-406f-9890-1125ceb0a84b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c160708b-aa92-4fb6-b31d-d1805396b242"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c3cbf559-b735-46d9-b6f7-be92c08eb42f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c4904074-9910-4dd2-97f3-24e4fa0f50bb"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c5e3644e-81bf-4486-9cdf-2606a82c2842"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c6af3102-c1ec-45aa-ad1f-c467cc311c93"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c8a80b13-eabb-4bac-b1e6-409c33d13293"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c988b6b1-a0cf-469e-95c4-44348ca18b91"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cb6039b8-a6d3-4fe1-a3a1-c8900d0c039e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cd8b69fd-0c57-4edf-97c3-6d72c87e1371"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cdef7cf9-43b8-4aab-8d7c-32030a7b6651"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cf815bf9-48e0-44b5-b178-29e8d10eba8f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d18ac344-704b-4eae-a493-969f70b986fd"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d299dd8d-ac0b-4c19-aef9-868ffe511d65"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d3ddbfae-a2a3-4fdf-a9bf-9ed01e29bbd2"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d5eef13a-779c-4ce1-ba17-3ff9975da50a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d9eb377e-a515-4479-8b14-897da7f8f5ef"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("db46a5e0-7367-4db0-ba79-461d57d1c630"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("db47a52f-bc32-444f-8bbe-6f72278a6d7b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("dbb07b2b-a2a4-49ce-a782-a656be70adab"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("df7a1c37-1e10-43c7-874c-8609725bcff9"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e19b63f5-dbf7-490d-8756-ce8a395e0950"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e25f4a2b-5bfd-4b5d-95c9-8267787a6038"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e4a4aa4a-24e1-46ab-9849-f93939f1bdc4"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e4fb79be-fb3e-4943-a389-de49a882c079"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e5148de7-5fbf-445b-aedd-212d05dc529b"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e6658d34-58d6-46c3-8f30-f8d3c9a7b85a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e83e556a-f1e6-4b96-bda2-361f0ace4dc7"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ea3fba12-3c1e-4509-822b-1120e7a3d9db"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("eb21ed06-eba6-4938-b84d-c64650251a73"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ebb2a294-5851-4172-b439-dbf1657a1791"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ebb5c37f-c882-4f42-a98f-da95b67fe2ae"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ee56e575-3d37-4bb0-b67f-390d2023c621"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ef1d7040-2165-4829-9533-9b98de494d6f"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ef484c2e-a8d5-42b5-ac72-cbac98b3bea6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ef9383ff-a9e4-4a75-b896-6e937ea39491"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f09bd9c3-c219-431f-b0c0-0b024888c2ab"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f1050e18-81bd-42ed-8ad4-02c011e63fdf"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f131f4c4-d420-4b42-935f-664f94503b1d"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f1b53489-5f9d-4f86-bfae-5bde9ecaf168"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f2e4ef86-684d-491b-a8d4-6c725d355b97"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f38e0e78-d513-4a9b-b401-92ac322ab0dc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f39a5095-3545-4741-896c-da1a96786ac3"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f442504a-b412-4d87-86d8-cc5e3ecbd3f5"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f552ade0-6abe-4244-b39e-f8c7037c4a9e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f68ec5da-654d-4c9d-ae59-d80166c7153e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f7237574-f49b-43ca-b031-b83e1d70347c"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f7d44b01-6ab7-4192-a17e-04a3def0ab3a"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f9cabba1-0c36-4541-b9f7-939c37f47299"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fa42c808-0979-4724-ac3a-8f6d403ef7fd"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fb07a14e-5f3e-4098-9daa-60ed2f062d51"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fc49ba99-119e-43dc-9eab-d203d74a39b6"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fd337ee6-78ae-4a57-8cc6-9a5ffbe39b9e"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fdb7ce10-f148-4fb4-8788-0f6283419896"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fdcf3dbd-5088-443c-a766-68e3dca3bda0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("06145600-782e-438c-ba61-6385413eb5d6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("04abf890-152a-4449-a9bd-712d1f5511ac"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("06ffe47c-1e7e-40b7-ad5f-b4d6cce2a83d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("158093b1-e570-4565-9d56-8cb0c3a8925b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15fb602f-0fdf-46a0-b9ef-eccf9957266a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1a8396fa-8e42-496d-9a57-4116da111dde"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1ff07180-6fb8-48ac-ba4e-bfc057c68b2b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2c348380-5c54-40b0-8a68-ac3510b4407e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2f0e64dd-34a8-4c7d-ae94-4764d4eba0a3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("313aa27d-e03e-439a-a08f-cc0163b265a4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3666f334-d391-4658-be13-413d89c27735"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3e60df1f-d972-4bf4-bccd-833d62d9e2a7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4805eae1-e38f-4a71-ab9e-d491be830968"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("52ef881a-1432-4ce8-9d79-5c95587621a5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("567f427e-691b-45ff-8db7-25eb24df7b05"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("597c29dd-2951-44a1-a810-179be6cceb22"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5ce311dd-a06f-4c09-9eb3-5d38332277a8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5d6b8ddc-72b9-4035-8525-cae292999fab"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("70a9617e-e509-45e8-aa9d-ac82904de345"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("70d29078-472a-4e29-8848-8f64efe87b40"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("76f3e60a-a48c-405e-ae04-272ca1108f89"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("821a6361-22e5-4fbe-b69f-9009059e2c18"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8280aeed-66cc-4bd9-845c-ba1d3a5b65bf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("82d6cb7d-6431-46ad-a6a1-51950a3e1ead"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8572847b-13b4-4b4b-af77-bf04fb7285c2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("866c1a50-e425-4a65-ac1f-018bcbd0a04d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8cb4f6cb-e201-4b89-afd6-8f4db610b3a3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("94e1c0d2-f2b6-4197-af1a-1f4f5859f105"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("980c4628-5eba-4838-93f4-f963dd04689b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a18508dc-5005-4a95-8b27-d7ce1031b058"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("aa261eba-e3f3-455a-8970-b494649ecb9d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ad4d6137-e7c2-4827-a80b-def70a8b1477"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b0555db0-3dfc-4065-b190-3c3a380d2a94"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b0af6292-4408-4503-b6d7-c946b9f816cc"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b44be778-6c57-45bd-ac38-68823b44ca84"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b5b9f980-c210-445a-b3a1-227dc2e39050"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bb970028-da82-4d56-8622-bfc1c0427d38"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bf639bf8-cca4-4383-a41c-d7eda77290e0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c58543e8-b13a-4fd9-a8a2-dcfd304ed019"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cb1f1bfc-e929-476a-aa0d-31c997f6098b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cb7912af-366d-421f-9b67-f609faa7c9ca"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cca046ab-610f-425a-b8e3-5eeb51a2def3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d22e335b-1b50-4885-b430-2c8ade2ca7f7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d8c4b9b5-d52b-437d-86df-7567c501213f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("dadb8690-a38d-4118-ada4-c5a0c889c29e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e106bc08-0ad1-4305-ab96-91468ac8f043"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e660f2f0-cc6d-4498-bb05-b11b3d896422"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f2d88e14-5e40-4458-9242-4397d9f3f0c6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fb45da69-7ff0-4c23-9403-710993b9f3c2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fdc6cda7-34cc-4cf3-a20a-c608384bc077"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("0af4e9ea-8e3d-4cac-a94c-9be1e8e82a78"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("1b6a5283-731d-49b8-b574-03c4040a05a0"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("43f5c2c9-4c7b-4bb6-b698-203056470fc2"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("cd67ee4b-bef1-4694-85fb-22e63f199f3b"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("efebd263-7f71-400d-aa0b-6d884065e9b7"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "CreationDate", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("02336dc2-d874-432e-a769-43c849479893"), "11893 Icie Shore, O'Harahaven, Peru", new DateTime(2022, 11, 27, 19, 31, 47, 463, DateTimeKind.Utc).AddTicks(9613), "Matteo31@hotmail.com", "Lynch - Haag", "1-610-701-0220 x94891" },
                    { new Guid("3a242560-9358-49ec-9fab-c494274a3881"), "9143 Jacobson Springs, South Forestbury, Guyana", new DateTime(2022, 11, 27, 19, 31, 47, 463, DateTimeKind.Utc).AddTicks(9275), "Boris.Cassin@gmail.com", "Schinner, Ernser and Bradtke", "687-800-8284" },
                    { new Guid("4532e989-562f-4cc7-8032-24ce119ec592"), "96346 Leffler Garden, Jaquanberg, Guatemala", new DateTime(2022, 11, 27, 19, 31, 47, 463, DateTimeKind.Utc).AddTicks(8761), "Elvis99@gmail.com", "Ankunding, Zemlak and Schoen", "1-363-419-0946 x012" },
                    { new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a"), "522 Ferry Burg, Lazaroville, Monaco", new DateTime(2022, 11, 27, 19, 31, 47, 463, DateTimeKind.Utc).AddTicks(9862), "Myrtie_Schmidt@gmail.com", "Rodriguez Inc", "(451) 498-0387 x3884" },
                    { new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c"), "1602 Fidel Village, Port Marisol, Niue", new DateTime(2022, 11, 27, 19, 31, 47, 463, DateTimeKind.Utc).AddTicks(7747), "Rene_Torphy@gmail.com", "Brown and Sons", "(679) 701-3717" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreationDate", "Email", "Name", "PhoneNumber", "RestaurantId", "Role", "Surname" },
                values: new object[,]
                {
                    { new Guid("0396a544-13b0-4c60-bb39-50c79947b110"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7051), "Lonie38@gmail.com", "Roxane", "(966) 278-5500 x1772", new Guid("3a242560-9358-49ec-9fab-c494274a3881"), "Waiter", "Bogan" },
                    { new Guid("07562891-6b81-44fd-a4b5-e77b533e2a88"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7680), "Nils82@gmail.com", "Rosalind", "1-557-695-5294 x10311", new Guid("3a242560-9358-49ec-9fab-c494274a3881"), "Waiter", "Leffler" },
                    { new Guid("0ac2d78f-ceb5-4f54-906d-f8b8ffe829fd"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7535), "Remington_Legros@hotmail.com", "Ernestine", "622-564-7688 x545", new Guid("3a242560-9358-49ec-9fab-c494274a3881"), "Cook", "Heaney" },
                    { new Guid("1034ea46-27d5-4e25-8a78-4371db5e8712"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8602), "Brenna55@gmail.com", "Mylene", "1-226-813-1382 x93047", new Guid("4532e989-562f-4cc7-8032-24ce119ec592"), "Waiter", "Wilderman" },
                    { new Guid("14c6f5e4-cc3c-4ac6-bdae-78df661af537"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8204), "Albin_Jerde@yahoo.com", "Dorian", "257-613-3172 x662", new Guid("02336dc2-d874-432e-a769-43c849479893"), "Manager", "Sporer" },
                    { new Guid("2793c69b-22de-460d-b8f2-4ed2ce24fc71"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(6862), "Zakary_Klocko@gmail.com", "Crystal", "525.406.8548", new Guid("02336dc2-d874-432e-a769-43c849479893"), "Cook", "McDermott" },
                    { new Guid("2f561fd9-3ce8-47e9-a968-3287d486f882"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7818), "Cecil.Kshlerin@yahoo.com", "Sylvia", "1-663-663-8723 x8001", new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a"), "Waiter", "Barrows" },
                    { new Guid("326f6e9e-a689-4498-a71b-8153fd7a262b"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(6485), "Keith94@gmail.com", "Eldora", "1-586-600-9187", new Guid("3a242560-9358-49ec-9fab-c494274a3881"), "Manager", "Predovic" },
                    { new Guid("34e73bb7-fb2b-4333-8674-e1d8aa6ae908"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8258), "Jeanne.Treutel30@yahoo.com", "Cindy", "202-287-2735", new Guid("4532e989-562f-4cc7-8032-24ce119ec592"), "Waiter", "Leannon" },
                    { new Guid("37e660ac-0848-4a31-9b2e-3f1608be8706"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7478), "Verlie13@yahoo.com", "Joy", "(763) 588-9328 x067", new Guid("02336dc2-d874-432e-a769-43c849479893"), "Manager", "Runolfsson" },
                    { new Guid("3be96c3e-5496-45f4-984e-d18baa649e9c"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8687), "Aglae_Stiedemann@gmail.com", "Robyn", "(291) 633-4228", new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c"), "Cook", "Feest" },
                    { new Guid("3db7aaac-8e8a-4cff-942e-d0d70eb90c6c"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8546), "Kendrick.Conn@hotmail.com", "Destinee", "(818) 893-5308 x1977", new Guid("02336dc2-d874-432e-a769-43c849479893"), "Manager", "Ondricka" },
                    { new Guid("42c14b2e-66a6-4f51-a856-8222f9cde717"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7210), "Rashad_Bruen90@yahoo.com", "Luther", "464.521.5673", new Guid("4532e989-562f-4cc7-8032-24ce119ec592"), "Cook", "Adams" },
                    { new Guid("59b82658-858b-47d9-af0b-2377b9f53b03"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8800), "Tevin83@yahoo.com", "Oral", "790.372.1791 x940", new Guid("3a242560-9358-49ec-9fab-c494274a3881"), "Waiter", "Corkery" },
                    { new Guid("5e89d3ca-9454-4e23-8532-fc383b8983d5"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8353), "Paxton_Johns91@yahoo.com", "Garnet", "(307) 987-9095", new Guid("02336dc2-d874-432e-a769-43c849479893"), "Waiter", "Lueilwitz" },
                    { new Guid("62d8eaa6-84e5-4b64-b603-469fc6452abc"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(6938), "Jeffery_Kertzmann@yahoo.com", "Raheem", "608-807-7172 x167", new Guid("3a242560-9358-49ec-9fab-c494274a3881"), "Manager", "Lowe" },
                    { new Guid("661b7c88-90e1-4567-b47b-b36e6bd16b84"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8150), "Lexie96@hotmail.com", "Sherwood", "977.207.0327", new Guid("02336dc2-d874-432e-a769-43c849479893"), "Waiter", "Cummings" },
                    { new Guid("67372889-4486-4415-9de9-45b59301837a"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7878), "Gwendolyn_Koss@hotmail.com", "Dannie", "(206) 443-1244", new Guid("4532e989-562f-4cc7-8032-24ce119ec592"), "Waiter", "Hodkiewicz" },
                    { new Guid("6c05ee74-5c3e-4e49-821d-9dab6828f2e4"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8406), "Deven3@gmail.com", "Clifford", "(974) 489-2864", new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a"), "Manager", "Hammes" },
                    { new Guid("906ca5a6-08c3-4cb1-a338-fcffd376ddf8"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7959), "Samir63@yahoo.com", "Werner", "688-511-7236 x2196", new Guid("4532e989-562f-4cc7-8032-24ce119ec592"), "Cook", "Funk" },
                    { new Guid("afc2d4a9-cbaf-4a5d-8e82-fa745a13875c"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7419), "Tyson4@hotmail.com", "Anabelle", "(931) 216-8473", new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c"), "Manager", "Leffler" },
                    { new Guid("ba5a17e3-a49e-4f66-9e79-c80f5538d78f"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8071), "Skyla11@hotmail.com", "Jewell", "(725) 968-7598", new Guid("4532e989-562f-4cc7-8032-24ce119ec592"), "Cook", "Greenholt" },
                    { new Guid("c4c1577a-2b66-4017-a633-2abd7f04c710"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7270), "Julio74@hotmail.com", "Hershel", "335.257.3518 x64238", new Guid("02336dc2-d874-432e-a769-43c849479893"), "Manager", "Hilpert" },
                    { new Guid("d7cc465c-d786-4767-bb1a-454fe08ee929"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7762), "Ed_Bergnaum51@yahoo.com", "Desiree", "(727) 659-7117 x9894", new Guid("3a242560-9358-49ec-9fab-c494274a3881"), "Cook", "Muller" },
                    { new Guid("d8fa8d9a-212c-402c-a1a4-1421f1e0b2e4"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8745), "Melba50@hotmail.com", "Adela", "454.792.1859 x1333", new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c"), "Waiter", "Stoltenberg" },
                    { new Guid("dcad00ad-d5e9-45e4-bf45-2f54db976d38"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8458), "Bart_Will@hotmail.com", "Rodger", "439.771.2265 x35582", new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a"), "Waiter", "Hudson" },
                    { new Guid("e1aee5ce-ad68-42f5-b411-e8db04d51025"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(8017), "Sigurd_Carter@yahoo.com", "Domenico", "1-990-961-5270 x554", new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c"), "Waiter", "Graham" },
                    { new Guid("f3266847-5f68-41d9-bd9c-eaa2025138da"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7118), "Mortimer_Ernser10@hotmail.com", "Guiseppe", "921.671.2200 x74193", new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c"), "Manager", "Gleichner" },
                    { new Guid("f4cd5810-b0e1-4f6f-aff8-e15a72081038"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7331), "Sandrine95@yahoo.com", "Kian", "387-724-7092 x31195", new Guid("02336dc2-d874-432e-a769-43c849479893"), "Manager", "McDermott" },
                    { new Guid("fc3d155b-df8e-4310-8f52-8e896346bd7a"), new DateTime(2022, 11, 27, 19, 31, 47, 466, DateTimeKind.Utc).AddTicks(7620), "Jovanny.Cummerata48@hotmail.com", "Zula", "1-205-644-6990 x1955", new Guid("4532e989-562f-4cc7-8032-24ce119ec592"), "Waiter", "Hahn" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreationDate", "Description", "Item", "Price", "Quantity", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("01377514-28ca-43e1-aa83-518fa09b564d"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4257), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Metal Sausages", 97.578948019807693m, 4, new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a") },
                    { new Guid("044987e9-740f-452e-a5b6-b8627043408f"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3673), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Wooden Tuna", 81.165952471627792m, 4, new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a") },
                    { new Guid("0da985ec-8521-4450-91aa-38020708febf"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3755), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Wooden Mouse", 35.192317857496579m, 9, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("11b275d2-04b9-4b10-bae9-d148507e2500"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4461), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Metal Towels", 39.707028698971006m, 8, new Guid("02336dc2-d874-432e-a769-43c849479893") },
                    { new Guid("18a223ba-7aa7-4797-8d06-99bdfc18e095"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3967), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Concrete Cheese", 98.701421517739765m, 2, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("2420631d-50b2-4897-bd00-4fbc423dff29"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4012), "The Football Is Good For Training And Recreational Purposes", "Intelligent Cotton Cheese", 52.078607128038358m, 8, new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a") },
                    { new Guid("2e71e22f-1797-4243-b18c-7b0c341dca00"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3553), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Frozen Towels", 81.291850958155375m, 1, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("3232f40a-d468-4fc5-9c64-60d6c02c4f72"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4129), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Metal Hat", 41.025619855162513m, 7, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("3626c1f0-9e47-44a7-a9e9-19c57aef98a9"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4073), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Frozen Mouse", 77.827932043852231m, 1, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("38cd985d-281d-4b97-8c76-02c744d93921"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4337), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Rubber Bacon", 19.998994586057497m, 2, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("41dce256-e942-474e-981c-f3aaa850bf26"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3336), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Plastic Chicken", 9.8111542252875625m, 8, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("44fce4b8-c92e-4333-a41f-a8a9967c12db"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3736), "The Football Is Good For Training And Recreational Purposes", "Licensed Fresh Fish", 75.949547890084615m, 3, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("522e8e31-b04c-4817-8a59-ce459b7519db"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4422), "The Football Is Good For Training And Recreational Purposes", "Generic Cotton Car", 57.230385630964534m, 10, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("5456b3b0-c1fc-4df0-aea5-eb32db42eae2"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3926), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Plastic Pizza", 75.490387418535715m, 3, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("5471e8ad-5d90-4613-bf04-a9fa8fa9c25e"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3906), "The Football Is Good For Training And Recreational Purposes", "Small Soft Tuna", 12.652859094856705m, 1, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("56968c06-0cb7-41f0-a7b3-98a05d9031bd"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4150), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Cotton Salad", 69.043895312139703m, 1, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("60277dd4-806a-4372-8ed5-5a0d6c531e60"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4375), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Fresh Pizza", 6.1255486738521406m, 8, new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a") },
                    { new Guid("69b9d672-ae37-4744-b60f-0770a093bac6"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4479), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Rubber Keyboard", 45.89308294509214m, 10, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("6aafd901-1ec2-4f93-922a-1d6b0a66597d"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3844), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Fresh Sausages", 25.387679749349026m, 2, new Guid("02336dc2-d874-432e-a769-43c849479893") },
                    { new Guid("6ded39bf-43f3-42dd-b8ff-eed70e3ef3c9"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4296), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Granite Pizza", 54.287827598530756m, 9, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("7e8cbad5-5d5b-4bbb-a79c-fe12755ab2e0"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3629), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Plastic Salad", 90.959913988113367m, 5, new Guid("02336dc2-d874-432e-a769-43c849479893") },
                    { new Guid("8428159b-2477-401a-ba3f-e81f56d93092"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3252), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Concrete Chair", 1.74855786177728215m, 1, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("8693aaae-c426-4581-ba2c-84f161ba0857"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3374), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Plastic Fish", 65.701310062176172m, 9, new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a") },
                    { new Guid("8c2654c3-d143-456c-a4fd-1da684494948"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4092), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Fresh Bacon", 22.833833344203331m, 2, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("8d2538b0-b153-441b-af40-2f163bd58dc9"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3478), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Sleek Metal Soap", 59.941903518020116m, 9, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("8ef699ce-b0c4-42be-87b9-0316bb9ef9de"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(2856), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Cotton Keyboard", 31.361360390373232m, 2, new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a") },
                    { new Guid("90289f32-0926-481a-8f66-10f2c1e44ee3"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4235), "The Football Is Good For Training And Recreational Purposes", "Awesome Concrete Gloves", 50.318400277904428m, 5, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("90aa33c9-4568-43d7-91e1-a46943362cf5"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4215), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Rubber Pants", 72.223463362186927m, 9, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("96d6bafe-a501-48a1-9941-20c6dc37dfd8"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3503), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomic Cotton Computer", 87.655121670875329m, 7, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("97e96552-a91d-4762-a6f9-fc58dcd572cb"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3428), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Metal Fish", 5.0115892868543008m, 1, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("a2596700-f588-4180-b254-b0d55087aac1"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3823), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Granite Pants", 53.595881986709215m, 6, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("a4fa77e8-aa2b-4739-a9a1-6b23f37a60fb"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4314), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Wooden Chips", 68.362399984785499m, 7, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("a6ba5355-f9b5-4ad2-a9f8-791987a8e502"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3604), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Soft Pants", 58.877750568966229m, 2, new Guid("02336dc2-d874-432e-a769-43c849479893") },
                    { new Guid("a716f01f-cd23-4858-a543-6074521088ad"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4442), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Frozen Hat", 94.946991149311399m, 3, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("b476e99b-a109-4b3f-b12f-a80f695c8bf3"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3869), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Fresh Hat", 55.789858830529207m, 1, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("badd3334-11c4-49c8-ae42-7d50b4623b9d"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3715), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Soft Hat", 73.539013501042066m, 3, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("bdf8b66e-9f87-4661-8586-db2913a0f6d3"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3526), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Steel Cheese", 17.727801994759537m, 10, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("c318b8a2-96be-416b-9b5f-dab8a15777ff"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4275), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Practical Fresh Shoes", 92.77639623208738m, 6, new Guid("3a242560-9358-49ec-9fab-c494274a3881") },
                    { new Guid("c5beb321-7f9d-4c1e-afd4-068e16921f37"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4169), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Rubber Tuna", 63.717927022705735m, 8, new Guid("02336dc2-d874-432e-a769-43c849479893") },
                    { new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3946), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Concrete Chair", 78.457719934386055m, 1, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("cc4062ab-bb77-4c18-828b-79a9b0bf52be"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3888), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Concrete Chips", 82.975748718704896m, 1, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("d088537e-afa3-4c09-a363-64e336f85566"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4034), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Rustic Plastic Pants", 9.7346689397164945m, 2, new Guid("46ee3bc8-f888-484b-b13e-8a9520d9022a") },
                    { new Guid("debf05d5-2bda-4ff1-b35d-387cbb6f3217"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3651), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Metal Shirt", 92.606178554057233m, 2, new Guid("02336dc2-d874-432e-a769-43c849479893") },
                    { new Guid("e1e6c1f0-a10e-4a62-8028-ff57d58d658d"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4054), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Metal Pants", 98.090623055161252m, 9, new Guid("02336dc2-d874-432e-a769-43c849479893") },
                    { new Guid("e351de89-7efc-4e4e-b6a3-c4be60f55b59"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4356), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Metal Gloves", 63.956836149076342m, 7, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("e5bf3077-49e3-4ded-ba89-2e21c31de1e2"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3404), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Metal Sausages", 4.829817586964842m, 2, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("e6386b84-2a55-4306-bfbf-8165431988d3"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3693), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Steel Table", 36.332572167428437m, 8, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("e74591ba-43a0-4578-959b-46e2f71e44b8"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3776), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Metal Fish", 72.304783756986637m, 8, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") },
                    { new Guid("ef8a1d2f-8843-492a-9020-2f61f9c49b30"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(4111), "The Football Is Good For Training And Recreational Purposes", "Tasty Wooden Mouse", 53.542415632653199m, 3, new Guid("eaed88f5-2297-4297-8d7f-045c72f65e8c") },
                    { new Guid("feaf3dd4-2c2f-4003-86b8-a4e2682bbf1c"), new DateTime(2022, 11, 27, 19, 31, 47, 465, DateTimeKind.Utc).AddTicks(3453), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Granite Chips", 49.365517168941643m, 1, new Guid("4532e989-562f-4cc7-8032-24ce119ec592") }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "CreationDate", "OrderId", "Text" },
                values: new object[,]
                {
                    { new Guid("03cb6ebd-cc9b-4628-9ec6-18ec75614fea"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6290), new Guid("b476e99b-a109-4b3f-b12f-a80f695c8bf3"), "Numquam omnis nulla et modi nihil est occaecati sunt in." },
                    { new Guid("03fe4aad-db6f-4a1d-a6c8-c0e67852301c"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8462), new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), "Adipisci qui vel vitae et voluptatem maiores." },
                    { new Guid("0702681d-dbdf-40a3-95fa-bcd4c6069c06"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5903), new Guid("e6386b84-2a55-4306-bfbf-8165431988d3"), "In quis nulla rerum commodi impedit voluptatem rerum molestias autem." },
                    { new Guid("07e6202c-d1de-425a-a43c-0a4a3e83bb41"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6449), new Guid("6aafd901-1ec2-4f93-922a-1d6b0a66597d"), "Voluptas et et asperiores qui dicta earum." },
                    { new Guid("086fc4d9-4757-4e78-a601-fd843700a17a"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4984), new Guid("90aa33c9-4568-43d7-91e1-a46943362cf5"), "Nihil quibusdam et quo odit." },
                    { new Guid("0e960484-1447-482e-837c-a1f04772c266"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5776), new Guid("a2596700-f588-4180-b254-b0d55087aac1"), "Est saepe mollitia id aut exercitationem." },
                    { new Guid("10c7bd6a-8a69-4edc-9793-c93f36d408db"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6600), new Guid("44fce4b8-c92e-4333-a41f-a8a9967c12db"), "Delectus rerum et voluptates minus aut quas quis perspiciatis." },
                    { new Guid("11129887-01df-423e-9519-f415f7cb4fdf"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4804), new Guid("5456b3b0-c1fc-4df0-aea5-eb32db42eae2"), "Reprehenderit accusantium consequatur incidunt." },
                    { new Guid("13b98608-adf7-4238-87ab-fce4dc5e8867"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7586), new Guid("cc4062ab-bb77-4c18-828b-79a9b0bf52be"), "Aut dolor iusto." },
                    { new Guid("13ee8105-e709-4672-9ffa-75d2149195df"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4742), new Guid("5456b3b0-c1fc-4df0-aea5-eb32db42eae2"), "Reprehenderit quibusdam ipsum nostrum recusandae vel error." },
                    { new Guid("1a477b7d-37cd-41e1-a824-b53009b390dd"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7672), new Guid("8693aaae-c426-4581-ba2c-84f161ba0857"), "Accusantium nemo iure non necessitatibus sed nulla voluptatem earum aut." },
                    { new Guid("1c174f65-a11b-4c7d-b5d6-bd36cdba11e4"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7486), new Guid("38cd985d-281d-4b97-8c76-02c744d93921"), "Quo deleniti et ut voluptas dignissimos laborum." },
                    { new Guid("1c7abd8f-d4b2-4fff-9707-4d62a628b32f"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5513), new Guid("feaf3dd4-2c2f-4003-86b8-a4e2682bbf1c"), "Qui dolorem omnis non dolorum ut dolore et." },
                    { new Guid("1f7268ca-a92f-45b0-8844-15a85cecc2a7"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4785), new Guid("5456b3b0-c1fc-4df0-aea5-eb32db42eae2"), "Vel optio dolore eveniet est." },
                    { new Guid("1ff2729b-486b-4179-b36c-48e538ef637b"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6945), new Guid("6aafd901-1ec2-4f93-922a-1d6b0a66597d"), "Ratione nam consequatur saepe unde vero." },
                    { new Guid("20677516-d8d9-43bc-8bd5-a64faffbcf0a"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3836), new Guid("69b9d672-ae37-4744-b60f-0770a093bac6"), "Officia ea sint." },
                    { new Guid("21b6c74c-bc4b-44a9-969e-0980d2cde108"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5691), new Guid("96d6bafe-a501-48a1-9941-20c6dc37dfd8"), "Sed voluptatem asperiores eius ea." },
                    { new Guid("21c0cb2d-47d1-450f-8fba-d866ce320c6e"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6965), new Guid("90289f32-0926-481a-8f66-10f2c1e44ee3"), "Dignissimos enim autem nihil doloribus rerum sunt animi quo." },
                    { new Guid("2464acb6-9ff2-428f-9fd7-c340e60e852d"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4326), new Guid("ef8a1d2f-8843-492a-9020-2f61f9c49b30"), "Sed aut itaque voluptatem velit neque." },
                    { new Guid("25ed3691-4419-463a-858e-6df02726cc73"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7797), new Guid("97e96552-a91d-4762-a6f9-fc58dcd572cb"), "Quibusdam tempora commodi labore voluptas voluptatem unde enim." },
                    { new Guid("27f34e2e-4ce9-4fc3-9019-8daf45de07ef"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4640), new Guid("2420631d-50b2-4897-bd00-4fbc423dff29"), "Necessitatibus saepe perspiciatis est amet." },
                    { new Guid("28ffbac7-97a7-4d37-ab6c-92ce1b641548"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3908), new Guid("8d2538b0-b153-441b-af40-2f163bd58dc9"), "Exercitationem voluptatum maxime sed voluptas ab illum quidem odit." },
                    { new Guid("2932d2ee-5461-4421-8d60-5ff63f4e889e"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3641), new Guid("e5bf3077-49e3-4ded-ba89-2e21c31de1e2"), "Excepturi eum et saepe quod earum facere." },
                    { new Guid("2ae4b50f-60bd-4b1b-80fc-104e0ac5a820"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4402), new Guid("044987e9-740f-452e-a5b6-b8627043408f"), "Asperiores velit voluptatum quia illo voluptatibus veritatis illo porro." },
                    { new Guid("2c1cc232-aa5f-4348-9cfe-305864466337"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8112), new Guid("a2596700-f588-4180-b254-b0d55087aac1"), "Rem qui id illum." },
                    { new Guid("2df44ab0-82d8-4da1-b7b4-a357a51ddc49"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3579), new Guid("8ef699ce-b0c4-42be-87b9-0316bb9ef9de"), "Fugit unde ipsa doloremque labore rerum veniam harum ea." },
                    { new Guid("2e297a80-631e-4c1c-8dca-25acf465969f"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7121), new Guid("c318b8a2-96be-416b-9b5f-dab8a15777ff"), "Ut consequatur voluptatem reiciendis similique dolores aperiam." },
                    { new Guid("2e854f28-fe8f-495f-b255-4a946f560385"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3553), new Guid("2e71e22f-1797-4243-b18c-7b0c341dca00"), "Qui voluptatibus id explicabo illo laborum." },
                    { new Guid("301e27c8-7fec-4e6f-870e-c47134443cf6"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8292), new Guid("8693aaae-c426-4581-ba2c-84f161ba0857"), "Aut quasi amet." },
                    { new Guid("31db2e01-e9d0-46c4-afe6-9092675ed0d3"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8395), new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), "Non consectetur beatae facilis." },
                    { new Guid("32223c70-4fc9-4054-8cc1-c2f16fbd2c72"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4963), new Guid("e6386b84-2a55-4306-bfbf-8165431988d3"), "Sequi impedit ut numquam illum inventore." },
                    { new Guid("32e2f823-6562-4703-b921-461856ca9e16"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6693), new Guid("38cd985d-281d-4b97-8c76-02c744d93921"), "Iusto culpa porro voluptatem ut aliquam occaecati nihil fuga aliquid." },
                    { new Guid("343dd623-4d5f-44be-8352-0bd7b6169315"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3970), new Guid("3232f40a-d468-4fc5-9c64-60d6c02c4f72"), "Odit vel perferendis libero libero et." },
                    { new Guid("36313ea7-1753-4e23-bd7e-6901a54d2f11"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6472), new Guid("a4fa77e8-aa2b-4739-a9a1-6b23f37a60fb"), "Consectetur id aut optio." },
                    { new Guid("36d6d1f2-08b2-4566-9455-9ca8de158b99"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7601), new Guid("c5beb321-7f9d-4c1e-afd4-068e16921f37"), "Velit aut repudiandae." },
                    { new Guid("37fc0e79-aac8-4970-8298-9420c9a2d1ba"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3188), new Guid("38cd985d-281d-4b97-8c76-02c744d93921"), "Eum omnis dolor non perspiciatis voluptatum repellendus." },
                    { new Guid("39173d80-e792-4282-afc6-b099d9ad70f6"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8174), new Guid("5471e8ad-5d90-4613-bf04-a9fa8fa9c25e"), "Repellendus eius itaque voluptatem libero qui eos." },
                    { new Guid("3a666a63-1f68-4423-bf56-51cae0eed741"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7938), new Guid("e5bf3077-49e3-4ded-ba89-2e21c31de1e2"), "Odit pariatur culpa modi delectus molestias." },
                    { new Guid("3c09eab7-7054-45e0-9da8-b02484f62c41"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8307), new Guid("01377514-28ca-43e1-aa83-518fa09b564d"), "Error qui doloribus qui ducimus autem repudiandae dolores sequi tempore." },
                    { new Guid("3c3b0cb8-3d3b-4d73-b794-ecdf81cc1aa4"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5494), new Guid("bdf8b66e-9f87-4661-8586-db2913a0f6d3"), "Voluptate a ullam quas." },
                    { new Guid("40d12b66-fd83-43a7-8414-40aef237ef2d"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3852), new Guid("c5beb321-7f9d-4c1e-afd4-068e16921f37"), "Natus facere officiis quod dolores qui ut alias atque voluptate." },
                    { new Guid("41508bc6-c3da-4bab-9d41-61cb2228a200"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7458), new Guid("a716f01f-cd23-4858-a543-6074521088ad"), "Maiores commodi enim quia autem aliquid ut rerum magni eos." },
                    { new Guid("41675706-af01-4d5f-b82d-767be81d99c6"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4661), new Guid("8428159b-2477-401a-ba3f-e81f56d93092"), "Incidunt placeat qui minima quia quos rem earum ut." },
                    { new Guid("41dcb38b-d003-4773-b33b-b4f3d8a887e2"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4217), new Guid("96d6bafe-a501-48a1-9941-20c6dc37dfd8"), "Nulla maxime cumque amet minima omnis reiciendis rem." },
                    { new Guid("4344a895-50c0-49be-9889-f2d8b1bf2efa"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3420), new Guid("60277dd4-806a-4372-8ed5-5a0d6c531e60"), "Asperiores maiores quia dolores voluptatem." },
                    { new Guid("4378a9ec-7a81-4823-90cb-b7fe74bcc7ef"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8053), new Guid("5471e8ad-5d90-4613-bf04-a9fa8fa9c25e"), "Impedit quia animi." },
                    { new Guid("4498f246-2144-4c2d-84c2-d23672f03886"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7145), new Guid("6aafd901-1ec2-4f93-922a-1d6b0a66597d"), "Recusandae neque quo consequatur voluptatem quasi inventore aut atque ea." },
                    { new Guid("478b0567-ed8a-4793-8664-d3e1c33cfe35"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5882), new Guid("96d6bafe-a501-48a1-9941-20c6dc37dfd8"), "Natus consequatur adipisci est ea autem." },
                    { new Guid("4aaaea2b-7a58-422e-a4b6-b5e1a9877efa"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7191), new Guid("8c2654c3-d143-456c-a4fd-1da684494948"), "Commodi qui quaerat aut possimus cupiditate quia ut modi voluptates." },
                    { new Guid("4b8e3d10-6643-4dad-9414-5616250c9aca"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6235), new Guid("d088537e-afa3-4c09-a363-64e336f85566"), "Laborum repellendus illo dolores dolorem quia praesentium sint et." },
                    { new Guid("4ba3eead-a06a-4311-b31a-96f0d1cecabc"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6882), new Guid("d088537e-afa3-4c09-a363-64e336f85566"), "Quia rem pariatur." },
                    { new Guid("4d0907b6-4e1e-4e69-aa34-81f261698a00"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5237), new Guid("5471e8ad-5d90-4613-bf04-a9fa8fa9c25e"), "Fugit aut unde blanditiis id ad facilis molestiae necessitatibus consequatur." },
                    { new Guid("4de28089-8113-47cb-9924-7e1ddeb848aa"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7219), new Guid("a2596700-f588-4180-b254-b0d55087aac1"), "Omnis voluptatem doloremque ducimus error." },
                    { new Guid("4eb36dcc-ef07-48bd-b5a3-bb7041f36ad4"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7994), new Guid("7e8cbad5-5d5b-4bbb-a79c-fe12755ab2e0"), "A quis doloremque quia sit eveniet et omnis rem." },
                    { new Guid("4f1509d7-2320-4c73-83f1-328ac7ac7388"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5838), new Guid("d088537e-afa3-4c09-a363-64e336f85566"), "Saepe velit velit soluta sit quas dolorem delectus ratione consectetur." },
                    { new Guid("5037f20c-e3e6-459e-bb6e-9909406e0d88"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3524), new Guid("60277dd4-806a-4372-8ed5-5a0d6c531e60"), "Earum esse est in at et." },
                    { new Guid("508beaa8-8113-41e3-b355-8d15bbc85ccd"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6048), new Guid("7e8cbad5-5d5b-4bbb-a79c-fe12755ab2e0"), "Dolores et sunt ipsum neque." },
                    { new Guid("51637630-4a26-4a08-ae48-3fe7ed172951"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3884), new Guid("d088537e-afa3-4c09-a363-64e336f85566"), "Aut ex est animi mollitia." },
                    { new Guid("52baf472-e61e-4e82-ae8c-d509ab77aa85"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4164), new Guid("e5bf3077-49e3-4ded-ba89-2e21c31de1e2"), "Quae nobis omnis consectetur ad." },
                    { new Guid("52ddaf88-58a2-4998-8639-982a48387826"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7263), new Guid("a716f01f-cd23-4858-a543-6074521088ad"), "Quisquam nostrum velit suscipit." },
                    { new Guid("531aeb23-2d87-4e8f-86bf-962bb5d0210f"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5654), new Guid("c5beb321-7f9d-4c1e-afd4-068e16921f37"), "Aspernatur consequuntur rerum rerum dolor voluptatem." },
                    { new Guid("5363a3e3-8568-4ef7-bb79-7a2245d17377"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6789), new Guid("90289f32-0926-481a-8f66-10f2c1e44ee3"), "Et reprehenderit sed repellat dolores mollitia laudantium corrupti soluta eos." },
                    { new Guid("542b658e-5f0f-4b50-ac2b-6ee6b17abc68"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6557), new Guid("44fce4b8-c92e-4333-a41f-a8a9967c12db"), "Molestiae aut quidem cumque est magni aut nihil reprehenderit provident." },
                    { new Guid("558bd28b-9ca9-45a1-bcf6-ff05bcb184d0"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4143), new Guid("8428159b-2477-401a-ba3f-e81f56d93092"), "Consequatur esse tempore et." },
                    { new Guid("559123d4-c40b-4ad6-9303-fe0e2a31e09d"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6020), new Guid("bdf8b66e-9f87-4661-8586-db2913a0f6d3"), "Atque dignissimos ea eos ut iure enim ut vero." },
                    { new Guid("56485eb4-05b3-460c-92da-f2bd3a05f006"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8153), new Guid("e74591ba-43a0-4578-959b-46e2f71e44b8"), "Voluptatum laboriosam expedita consequatur dolor repudiandae." },
                    { new Guid("56a1530f-1103-4468-8ebf-0e0bb0951b2f"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7847), new Guid("41dce256-e942-474e-981c-f3aaa850bf26"), "Sed non saepe sequi exercitationem autem perferendis." },
                    { new Guid("57f5be52-5d92-4c80-b283-c071732d74ec"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5430), new Guid("69b9d672-ae37-4744-b60f-0770a093bac6"), "Et quisquam corporis accusantium nesciunt qui." },
                    { new Guid("5860b7b3-c1cf-4144-9cc8-e3e9e8c7b888"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4821), new Guid("69b9d672-ae37-4744-b60f-0770a093bac6"), "Dolores est iusto quo quae exercitationem quo hic tempora." },
                    { new Guid("586b2a25-3dc4-45d9-a419-1a84f83134c9"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7097), new Guid("feaf3dd4-2c2f-4003-86b8-a4e2682bbf1c"), "Sed a maxime ea aliquam dignissimos dignissimos illum." },
                    { new Guid("59803779-b88f-446c-b77b-4fbb08bdf334"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6318), new Guid("bdf8b66e-9f87-4661-8586-db2913a0f6d3"), "Fugiat corporis repellat aliquid eius officia." },
                    { new Guid("5c5226de-4b4e-4ef9-a9db-b559e879e660"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4070), new Guid("8c2654c3-d143-456c-a4fd-1da684494948"), "Eligendi cum rerum eos pariatur qui similique." },
                    { new Guid("5db80010-1147-419c-b55c-bc5b6586a7a8"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6736), new Guid("e5bf3077-49e3-4ded-ba89-2e21c31de1e2"), "Omnis facere est." },
                    { new Guid("5e27cfbc-a35f-444f-b32f-0cb79001e79d"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6395), new Guid("8d2538b0-b153-441b-af40-2f163bd58dc9"), "Dolor architecto vel et." },
                    { new Guid("5ee57bc9-d9c4-4ef0-a064-5af42a7896cb"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5321), new Guid("69b9d672-ae37-4744-b60f-0770a093bac6"), "Suscipit molestiae quisquam veniam accusantium sunt non sequi harum enim." },
                    { new Guid("5fc81e32-aca1-4d65-9e3f-26be4f5ee3ec"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4246), new Guid("debf05d5-2bda-4ff1-b35d-387cbb6f3217"), "Ut enim provident earum ducimus quia cum perspiciatis." },
                    { new Guid("5ffd2825-1c91-4066-b514-f66e6c3f4378"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8355), new Guid("522e8e31-b04c-4817-8a59-ce459b7519db"), "Deleniti non voluptas quo." },
                    { new Guid("6008fc25-811b-4710-ae52-782fa685005f"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4612), new Guid("56968c06-0cb7-41f0-a7b3-98a05d9031bd"), "Aut blanditiis iure adipisci odio aut et quo quia." },
                    { new Guid("6179532d-1424-4819-a6d5-271b0c45f99e"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4191), new Guid("97e96552-a91d-4762-a6f9-fc58dcd572cb"), "Tempore porro est occaecati consequatur quis." },
                    { new Guid("619ea6d4-c642-4c5b-94a1-6894e4e8442c"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7377), new Guid("60277dd4-806a-4372-8ed5-5a0d6c531e60"), "Expedita alias laborum quisquam dolorem expedita est excepturi blanditiis et." },
                    { new Guid("639a3978-736d-42f3-a004-fcaa61d565b0"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5674), new Guid("01377514-28ca-43e1-aa83-518fa09b564d"), "Quam consequatur iste." },
                    { new Guid("643ffd49-383f-40de-a838-1d1c976b8606"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4046), new Guid("18a223ba-7aa7-4797-8d06-99bdfc18e095"), "Asperiores vel quisquam est quos vel." },
                    { new Guid("65625d08-647c-4ae9-a8f2-733aa2a7ba79"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6992), new Guid("8ef699ce-b0c4-42be-87b9-0316bb9ef9de"), "Ullam repellat cumque pariatur ut iure." },
                    { new Guid("66eb0b0a-cf4f-46c1-9a88-4e9d886f96fa"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7616), new Guid("e6386b84-2a55-4306-bfbf-8165431988d3"), "Cum ut qui quo pariatur error soluta quibusdam ab ducimus." },
                    { new Guid("698115ef-239e-4a22-ad04-ae894c75871d"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3340), new Guid("97e96552-a91d-4762-a6f9-fc58dcd572cb"), "Eaque itaque nisi." },
                    { new Guid("6b35a4ed-9c07-49a8-b28c-eccd31e6e3dd"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6149), new Guid("41dce256-e942-474e-981c-f3aaa850bf26"), "Ipsam quasi dolorum ea dolores quia perspiciatis." },
                    { new Guid("6c1cac1b-ce1b-4f32-8dcf-12076861f870"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7897), new Guid("522e8e31-b04c-4817-8a59-ce459b7519db"), "Qui necessitatibus sunt velit." },
                    { new Guid("6cf0f2a7-9205-4dbc-91f3-be0d8f234b3c"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5536), new Guid("5471e8ad-5d90-4613-bf04-a9fa8fa9c25e"), "Dolorum quaerat commodi harum repudiandae tempore officiis debitis." },
                    { new Guid("6cf9eb9a-5630-48be-8408-7c7c4f629414"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7958), new Guid("96d6bafe-a501-48a1-9941-20c6dc37dfd8"), "Totam quia enim." },
                    { new Guid("6d7365dd-c61a-46ca-b81b-66da1f1087a1"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5350), new Guid("44fce4b8-c92e-4333-a41f-a8a9967c12db"), "Sunt veniam commodi et est maxime saepe." },
                    { new Guid("703b0ad9-61c8-46bf-91d4-55d4e7e46145"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5563), new Guid("e1e6c1f0-a10e-4a62-8028-ff57d58d658d"), "Et consequuntur harum et numquam ea voluptates architecto." },
                    { new Guid("709bd13e-cb00-4386-a483-4208546ab5df"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5050), new Guid("a716f01f-cd23-4858-a543-6074521088ad"), "Sit tempora consequatur quasi ut asperiores tenetur." },
                    { new Guid("71311fd3-a0fe-4734-afe1-8327c3e05b69"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6490), new Guid("debf05d5-2bda-4ff1-b35d-387cbb6f3217"), "Eum aperiam aut rerum optio reprehenderit consequatur laudantium." },
                    { new Guid("71d70155-0e88-4b1e-836f-99f416351027"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6896), new Guid("8c2654c3-d143-456c-a4fd-1da684494948"), "Molestiae exercitationem quia cum quo." },
                    { new Guid("75231cfe-188d-4ad0-9ca1-74d2bfc94f75"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7281), new Guid("8c2654c3-d143-456c-a4fd-1da684494948"), "Impedit amet occaecati ratione suscipit magnam." },
                    { new Guid("75e8a257-e10d-4feb-8762-b1679fce4e6b"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5073), new Guid("d088537e-afa3-4c09-a363-64e336f85566"), "Iusto magni praesentium." },
                    { new Guid("79818237-c65b-4cb0-8b79-b3422fbdebf8"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6339), new Guid("38cd985d-281d-4b97-8c76-02c744d93921"), "Eum accusantium nesciunt." },
                    { new Guid("7ae9bb01-42e5-43c1-b497-8a7865448b18"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7301), new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), "Illo odio autem cum ab tenetur veniam vel." },
                    { new Guid("7bfe9ba4-ffc8-4ed1-b6eb-ed9e2e26c7e5"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6915), new Guid("18a223ba-7aa7-4797-8d06-99bdfc18e095"), "Consectetur corrupti voluptatibus voluptatem vel quisquam quibusdam molestias omnis." },
                    { new Guid("7cf955ac-ba3a-42ef-a044-71f14dd1ef2e"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3689), new Guid("e6386b84-2a55-4306-bfbf-8165431988d3"), "Et quos sit." },
                    { new Guid("7d7fdd85-a424-4301-a4f5-3a1a25c1c742"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4299), new Guid("69b9d672-ae37-4744-b60f-0770a093bac6"), "Dolore sit facere quas impedit sequi dolores." },
                    { new Guid("7efda8e2-2073-4784-875b-421350ec57e7"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3385), new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), "Perferendis voluptatem optio occaecati sed placeat officiis occaecati." },
                    { new Guid("7f1ff2da-ac3f-4898-a2cf-d6babbd4d6a9"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5171), new Guid("b476e99b-a109-4b3f-b12f-a80f695c8bf3"), "Qui eum rerum maiores necessitatibus voluptates sint esse." },
                    { new Guid("82435ca1-f449-4ac3-8664-2bbd90715143"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3613), new Guid("56968c06-0cb7-41f0-a7b3-98a05d9031bd"), "Error odio architecto ut perferendis voluptatum error vel." },
                    { new Guid("829163cc-dfd4-4a31-82a9-0a8e52a1374a"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6816), new Guid("44fce4b8-c92e-4333-a41f-a8a9967c12db"), "Fuga aut impedit." },
                    { new Guid("842039c4-9c0e-405b-9814-205032a8093a"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7509), new Guid("ef8a1d2f-8843-492a-9020-2f61f9c49b30"), "Aut non aut sed dolor vel maiores non voluptatem praesentium." },
                    { new Guid("844087c5-9e88-4835-8814-e75d0eb8a5c7"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8411), new Guid("2420631d-50b2-4897-bd00-4fbc423dff29"), "Ratione et consectetur accusantium mollitia modi debitis." },
                    { new Guid("84da4c88-cbab-44c7-9ab5-40ba6aba15f1"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3313), new Guid("60277dd4-806a-4372-8ed5-5a0d6c531e60"), "Et corporis nam molestias." },
                    { new Guid("855cf1c5-1bb1-48d7-8e25-a9f96b6bb6e7"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7870), new Guid("e1e6c1f0-a10e-4a62-8028-ff57d58d658d"), "Facere sunt est omnis labore delectus mollitia aut officia recusandae." },
                    { new Guid("87d4704f-03a9-4414-b24e-9dc1728cb093"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6772), new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), "Quas enim quibusdam assumenda." },
                    { new Guid("8bfce13f-02a4-43f4-81d0-666bc67e3eab"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8223), new Guid("38cd985d-281d-4b97-8c76-02c744d93921"), "Alias nihil delectus qui velit aliquid quidem." },
                    { new Guid("8c617a5e-efd7-47bb-81a3-2b0e58ed466e"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3791), new Guid("2e71e22f-1797-4243-b18c-7b0c341dca00"), "Dolores optio provident omnis." },
                    { new Guid("8d952523-4756-4c5f-8535-a9c9ea293ca4"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5821), new Guid("e351de89-7efc-4e4e-b6a3-c4be60f55b59"), "Quae rerum non." },
                    { new Guid("8e08cd87-197c-4f1f-b338-07c60463b2d7"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5711), new Guid("3626c1f0-9e47-44a7-a9e9-19c57aef98a9"), "Et sed magni illo est assumenda." },
                    { new Guid("954557e5-3ab2-414b-89f3-2e77ad39e11d"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6189), new Guid("bdf8b66e-9f87-4661-8586-db2913a0f6d3"), "Ut illo omnis quibusdam eum rerum." },
                    { new Guid("95dd1ffa-004f-46ff-af92-fda43c75bebb"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7699), new Guid("bdf8b66e-9f87-4661-8586-db2913a0f6d3"), "Ratione ducimus et sunt cupiditate adipisci amet rerum." },
                    { new Guid("97b6eb53-0ed6-4d34-b951-3661ab9a0ea4"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6674), new Guid("97e96552-a91d-4762-a6f9-fc58dcd572cb"), "Necessitatibus facere corporis illum dolores ea." },
                    { new Guid("9bc222b6-133f-4b9e-9201-6d6228f9cc5e"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7405), new Guid("522e8e31-b04c-4817-8a59-ce459b7519db"), "Commodi dolores quia voluptatem veritatis consequuntur sed non non." },
                    { new Guid("9ce99e15-3d61-49a6-833e-1ddff666c906"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6172), new Guid("cc4062ab-bb77-4c18-828b-79a9b0bf52be"), "Perferendis quam aut." },
                    { new Guid("a12a0d93-a9c6-4214-9801-0155f1d0fd5a"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6752), new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), "Excepturi dolores culpa natus similique ea." },
                    { new Guid("a3418ac3-dfed-4d94-ac6f-30869e3481b1"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6515), new Guid("8c2654c3-d143-456c-a4fd-1da684494948"), "Illum aliquid ut non possimus." },
                    { new Guid("a459f3bf-43d9-457e-b72d-309e41f564ad"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4433), new Guid("2e71e22f-1797-4243-b18c-7b0c341dca00"), "Sed omnis omnis." },
                    { new Guid("a495f541-4694-49d1-93bf-37a0cfbb8190"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3364), new Guid("a2596700-f588-4180-b254-b0d55087aac1"), "Tempora in dolorem." },
                    { new Guid("a4d79d40-4185-44b1-b522-d46e284e9bc5"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8198), new Guid("7e8cbad5-5d5b-4bbb-a79c-fe12755ab2e0"), "Ratione placeat ut harum accusantium unde quod tempore et." },
                    { new Guid("a71842cb-0713-4652-b785-429a592b3908"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4934), new Guid("bdf8b66e-9f87-4661-8586-db2913a0f6d3"), "Exercitationem minus consequatur iure sunt provident consectetur amet." },
                    { new Guid("aadb61a3-cf74-4132-b70e-106565e43201"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5474), new Guid("c318b8a2-96be-416b-9b5f-dab8a15777ff"), "Qui sunt qui maxime quia magnam." },
                    { new Guid("aaf69997-43ae-430f-aea3-0e385a89cc97"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4892), new Guid("522e8e31-b04c-4817-8a59-ce459b7519db"), "Voluptatem ea qui." },
                    { new Guid("ac986693-8e34-43e5-953b-1ec27c29e3d3"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3727), new Guid("feaf3dd4-2c2f-4003-86b8-a4e2682bbf1c"), "Et aut officia et corrupti incidunt corrupti et id quisquam." },
                    { new Guid("ad196360-9f9e-492b-b20d-b4b2b2115a40"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5026), new Guid("c318b8a2-96be-416b-9b5f-dab8a15777ff"), "Quia architecto molestiae blanditiis temporibus vel." },
                    { new Guid("b200efd8-f62d-4079-ba80-b5f167e9cd86"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4868), new Guid("c318b8a2-96be-416b-9b5f-dab8a15777ff"), "Doloribus aut quisquam eum beatae ipsa qui." },
                    { new Guid("b4aa6167-9e7a-4ee0-8a14-9d8b665775fc"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5220), new Guid("8c2654c3-d143-456c-a4fd-1da684494948"), "Dolore quia harum molestias." },
                    { new Guid("b50dea5a-3b78-482b-9bfc-28cf7ef0e37c"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3668), new Guid("badd3334-11c4-49c8-ae42-7d50b4623b9d"), "Praesentium incidunt aut est." },
                    { new Guid("b5fe6c02-0545-473a-91a6-b1e4615e2713"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3445), new Guid("a4fa77e8-aa2b-4739-a9a1-6b23f37a60fb"), "Provident quibusdam ipsum dicta minus nobis exercitationem excepturi." },
                    { new Guid("b73fa064-1aa4-4f0b-a0d4-5ca1f182b6a7"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4101), new Guid("56968c06-0cb7-41f0-a7b3-98a05d9031bd"), "Non dolor rerum omnis aut provident ipsum." },
                    { new Guid("bda45469-c6db-40d0-b47d-fdd35ed6adc4"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6585), new Guid("8d2538b0-b153-441b-af40-2f163bd58dc9"), "Et sit praesentium." },
                    { new Guid("bf5b798f-0535-4eed-ab77-63b4c372f222"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8333), new Guid("522e8e31-b04c-4817-8a59-ce459b7519db"), "Vitae magnam atque quia voluptatem quas doloribus." },
                    { new Guid("c02a7993-5d60-4216-a8f4-980bbf24c871"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4512), new Guid("90289f32-0926-481a-8f66-10f2c1e44ee3"), "Minima maxime voluptas distinctio et suscipit cum est et fuga." },
                    { new Guid("c0c661d4-2db5-450f-b750-9c188a80d500"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5930), new Guid("5456b3b0-c1fc-4df0-aea5-eb32db42eae2"), "Architecto nihil laborum voluptas sint." },
                    { new Guid("c1e44d88-bf77-42d1-b616-77a0fdd5c8dc"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6722), new Guid("badd3334-11c4-49c8-ae42-7d50b4623b9d"), "Optio fugiat magni." },
                    { new Guid("c1f4d945-29c2-47d5-83f5-8ad084f0d460"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7074), new Guid("e74591ba-43a0-4578-959b-46e2f71e44b8"), "Ut et rerum numquam dignissimos vel et doloribus." },
                    { new Guid("c270d137-c04a-483a-bafa-13ad56a3aec6"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8504), new Guid("e6386b84-2a55-4306-bfbf-8165431988d3"), "Soluta quis pariatur possimus repudiandae temporibus." },
                    { new Guid("c2c350d2-9e08-4b15-b6c6-10c2dc85ac6d"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5635), new Guid("badd3334-11c4-49c8-ae42-7d50b4623b9d"), "Quia nostrum fuga blanditiis eius." },
                    { new Guid("c360220d-2e4e-4c5a-a835-3f63b6bfb353"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4590), new Guid("e5bf3077-49e3-4ded-ba89-2e21c31de1e2"), "Nihil minus iste illum nostrum aliquam." },
                    { new Guid("c3a83815-e35b-4ce8-9a23-bfdb5e0175ef"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7974), new Guid("8428159b-2477-401a-ba3f-e81f56d93092"), "A laboriosam dolores reprehenderit tenetur." },
                    { new Guid("c4978320-3cbc-4673-9eb6-c16f67793514"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4689), new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), "Consequatur rem fugiat veritatis omnis est quis ut." },
                    { new Guid("c51e1382-676e-4875-9406-1ee02f2d10ca"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5868), new Guid("3626c1f0-9e47-44a7-a9e9-19c57aef98a9"), "Facilis est nihil." },
                    { new Guid("c74b74ef-9149-4e15-9907-f19bcac655f6"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6108), new Guid("e6386b84-2a55-4306-bfbf-8165431988d3"), "Porro modi iste autem consectetur modi." },
                    { new Guid("c78e5cfc-88ab-4a88-8a7f-6b9d9b6a83e2"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8085), new Guid("2e71e22f-1797-4243-b18c-7b0c341dca00"), "Quia blanditiis rerum similique unde cum non blanditiis aut fugit." },
                    { new Guid("c870e73d-c8f3-42ef-b2cb-90dbf98a6524"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4561), new Guid("b476e99b-a109-4b3f-b12f-a80f695c8bf3"), "Qui a quos tempora rerum totam quidem dolorem." },
                    { new Guid("ca1a9225-7470-423e-9107-f1583cc545d4"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4847), new Guid("e6386b84-2a55-4306-bfbf-8165431988d3"), "Soluta voluptates odio vel doloremque." },
                    { new Guid("ca1aec3c-9de8-4f12-8e65-cda88c4bd2f2"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4544), new Guid("90aa33c9-4568-43d7-91e1-a46943362cf5"), "Ratione sed maxime." },
                    { new Guid("cd2d3997-6306-4d4e-b627-2ab82b8bb65c"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7559), new Guid("d088537e-afa3-4c09-a363-64e336f85566"), "Dolorum esse officia quis voluptas eos necessitatibus quia corrupti." },
                    { new Guid("ce25c9fa-3576-49fd-afbd-2f236bdcd103"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7013), new Guid("96d6bafe-a501-48a1-9941-20c6dc37dfd8"), "Velit nulla debitis." },
                    { new Guid("ceaaa2e0-d65d-4357-bfc7-819c0aab07e9"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6654), new Guid("60277dd4-806a-4372-8ed5-5a0d6c531e60"), "Sit corporis dicta voluptas perspiciatis." },
                    { new Guid("cecea595-ff89-4306-8f34-b05b026390d3"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4126), new Guid("0da985ec-8521-4450-91aa-38020708febf"), "Rerum qui enim." },
                    { new Guid("cee64a34-11c1-4d92-b3fd-8f87712c0d81"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3940), new Guid("d088537e-afa3-4c09-a363-64e336f85566"), "Quo dicta id quia in maxime dolorem temporibus inventore dolorum." },
                    { new Guid("cef347ac-3446-48c6-83bb-cdd16e7666c0"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7723), new Guid("8d2538b0-b153-441b-af40-2f163bd58dc9"), "Rerum voluptatem voluptas sunt doloribus in non velit iusto." },
                    { new Guid("d0d1b64e-3eab-4097-895e-629df4b6b7ad"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3709), new Guid("badd3334-11c4-49c8-ae42-7d50b4623b9d"), "Qui repellat nulla itaque." },
                    { new Guid("d2bf079d-fe4e-46f8-9808-720a5bffe797"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7536), new Guid("522e8e31-b04c-4817-8a59-ce459b7519db"), "Quia et ea omnis provident qui neque iste." },
                    { new Guid("d3036932-1ef5-4960-bbc7-4aa12a00ef02"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3810), new Guid("e74591ba-43a0-4578-959b-46e2f71e44b8"), "Praesentium deserunt temporibus quod sapiente est voluptatibus." },
                    { new Guid("d30d4901-ad26-40de-a7d6-387e2131e306"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8270), new Guid("56968c06-0cb7-41f0-a7b3-98a05d9031bd"), "Nam libero qui molestiae quibusdam odit pariatur." },
                    { new Guid("d348e8a5-fd89-4fb9-a37d-90d8695515da"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7352), new Guid("e74591ba-43a0-4578-959b-46e2f71e44b8"), "Est dolorem magnam ullam optio ab laboriosam nobis." },
                    { new Guid("d51632fd-0678-4cd9-81a5-c0dccfd3faa1"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5405), new Guid("0da985ec-8521-4450-91aa-38020708febf"), "Autem consequuntur eius explicabo voluptatem optio commodi." },
                    { new Guid("d58b6017-6ee5-4c5f-8df0-d28e59514b66"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6262), new Guid("18a223ba-7aa7-4797-8d06-99bdfc18e095"), "Corporis animi consequatur tempore id ut nisi hic tempore quia." },
                    { new Guid("d5fc98b6-a32e-4e94-bdcc-5c264f672557"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7774), new Guid("debf05d5-2bda-4ff1-b35d-387cbb6f3217"), "Amet dolorem error in facilis deserunt enim at." },
                    { new Guid("d7761500-728b-492e-be6c-586a8a0b3bc7"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5002), new Guid("2420631d-50b2-4897-bd00-4fbc423dff29"), "Qui iure labore minima in unde vitae inventore." },
                    { new Guid("dad31eda-228f-424a-8bef-aada656c27a7"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6859), new Guid("3232f40a-d468-4fc5-9c64-60d6c02c4f72"), "Molestiae debitis doloribus quasi modi similique tempore." },
                    { new Guid("dbd750a7-9595-4cf6-9133-b3fe4f214a46"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4351), new Guid("c5beb321-7f9d-4c1e-afd4-068e16921f37"), "Quisquam maxime vel quasi non officia laudantium eaque repellendus pariatur." },
                    { new Guid("dde89134-100b-49e9-9d77-55c90c5f8fe9"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5265), new Guid("11b275d2-04b9-4b10-bae9-d148507e2500"), "Porro tempore voluptate aliquid." },
                    { new Guid("dfa13824-8bc7-450d-b1b1-87f51161a7cf"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6536), new Guid("5471e8ad-5d90-4613-bf04-a9fa8fa9c25e"), "Porro cum ut deserunt doloribus." },
                    { new Guid("e02ec0fd-3043-4452-aa58-de7c973ccacc"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6092), new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), "Nostrum explicabo in." },
                    { new Guid("e0638ccf-bb55-4a75-8bc7-b84f3ad3d050"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7326), new Guid("90289f32-0926-481a-8f66-10f2c1e44ee3"), "Sed quo explicabo facilis inventore maiores numquam quia voluptatem." },
                    { new Guid("e3c0249e-1515-4d76-b401-757a50ee9f85"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5283), new Guid("8ef699ce-b0c4-42be-87b9-0316bb9ef9de"), "Dolores occaecati quo." },
                    { new Guid("e45b0389-2b16-4f2f-bf8d-6f5184067a4a"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6373), new Guid("a6ba5355-f9b5-4ad2-a9f8-791987a8e502"), "Placeat quasi eum voluptas minus voluptatibus in." },
                    { new Guid("e475335c-95da-412d-981c-034f9c0d1bfc"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8489), new Guid("5471e8ad-5d90-4613-bf04-a9fa8fa9c25e"), "Debitis laudantium velit." },
                    { new Guid("e58b2f09-9fab-40b4-b152-2cfdb8def9d6"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6068), new Guid("60277dd4-806a-4372-8ed5-5a0d6c531e60"), "Qui deleniti id eum molestiae earum neque necessitatibus." },
                    { new Guid("e68facb8-9ee7-4ea6-a04f-16281916e94a"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7173), new Guid("6aafd901-1ec2-4f93-922a-1d6b0a66597d"), "Sit nam est qui sint." },
                    { new Guid("e8049823-6188-4453-9415-fcb274b32c50"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4380), new Guid("5471e8ad-5d90-4613-bf04-a9fa8fa9c25e"), "Et voluptas ut aspernatur id." },
                    { new Guid("eb3ac607-7b80-4ad2-97a5-867e62dc3c98"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(2958), new Guid("a6ba5355-f9b5-4ad2-a9f8-791987a8e502"), "Doloribus error velit aut illo optio ducimus rem placeat." },
                    { new Guid("eb62450f-dc92-464b-b8d6-c7ddb81b9b39"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5090), new Guid("8693aaae-c426-4581-ba2c-84f161ba0857"), "Et est dolor qui tenetur voluptates laborum voluptas." },
                    { new Guid("eee3481f-b387-4fef-aea6-404d8d25c306"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5756), new Guid("8ef699ce-b0c4-42be-87b9-0316bb9ef9de"), "Sint qui facere rerum fugit." },
                    { new Guid("efc90c60-3ec0-4bd6-b64e-2b88d95e1d98"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5950), new Guid("56968c06-0cb7-41f0-a7b3-98a05d9031bd"), "Alias id voluptas sunt nihil totam fuga quia." },
                    { new Guid("f16de81f-d5de-4920-b671-3d264167cb5a"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3479), new Guid("c613daae-90bf-4d08-9d86-4c3277fcb21d"), "Iusto ducimus iste quis." },
                    { new Guid("f1acac30-3b53-48bd-a8fb-766b85de79c3"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6356), new Guid("3232f40a-d468-4fc5-9c64-60d6c02c4f72"), "Vel accusantium saepe atque." },
                    { new Guid("f1ce1b8a-8525-4f08-83a6-d48bbfa1a075"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7056), new Guid("8428159b-2477-401a-ba3f-e81f56d93092"), "Dolorum doloremque nihil non necessitatibus." },
                    { new Guid("f34a2764-70cd-4432-a43d-ef3e482963d9"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7914), new Guid("debf05d5-2bda-4ff1-b35d-387cbb6f3217"), "Quo quo doloribus necessitatibus quibusdam ullam quas dolorem aliquam." },
                    { new Guid("f3929ce7-899e-4525-a7ba-dea541ac90de"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5451), new Guid("c5beb321-7f9d-4c1e-afd4-068e16921f37"), "Vel quaerat odio ut et dolore." },
                    { new Guid("f3ba676d-d49c-42c8-9eda-4126462616f8"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(6129), new Guid("2e71e22f-1797-4243-b18c-7b0c341dca00"), "Minima totam cupiditate ut." },
                    { new Guid("f4e7a586-1e42-4b38-ab2a-16bac56b4adf"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(7749), new Guid("8428159b-2477-401a-ba3f-e81f56d93092"), "Asperiores sequi consequuntur architecto deleniti nemo iusto et velit." },
                    { new Guid("f5168fed-f465-406f-9dfc-fd617e39f998"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5204), new Guid("badd3334-11c4-49c8-ae42-7d50b4623b9d"), "Est occaecati sit." },
                    { new Guid("f6cace5e-f85d-4695-8d9e-d4c442a2f4da"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4448), new Guid("c5beb321-7f9d-4c1e-afd4-068e16921f37"), "Quibusdam laudantium odio eaque et nostrum laudantium et nemo voluptas." },
                    { new Guid("f88bef2e-1302-4717-bbe5-056d8147dc17"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8371), new Guid("c5beb321-7f9d-4c1e-afd4-068e16921f37"), "Eaque tempore maxime ipsum ea molestiae impedit ea." },
                    { new Guid("f8cf4b84-b275-45f3-a92d-03bf840de83d"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8070), new Guid("e74591ba-43a0-4578-959b-46e2f71e44b8"), "Eaque sint et." },
                    { new Guid("f924ddca-ad72-40f4-9e7b-49f08f15d272"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(8128), new Guid("7e8cbad5-5d5b-4bbb-a79c-fe12755ab2e0"), "Quasi rerum quia unde numquam ab error nulla quo voluptatum." },
                    { new Guid("fb080973-7288-4712-a8ed-2db193801807"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5299), new Guid("d088537e-afa3-4c09-a363-64e336f85566"), "At explicabo ea at asperiores nihil." },
                    { new Guid("fbc10af7-f632-4681-8d80-1f9289f89e33"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(4766), new Guid("8428159b-2477-401a-ba3f-e81f56d93092"), "Aut consequatur ut deleniti." },
                    { new Guid("fbd16226-f039-49a9-8e0d-f4b7b401da74"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(3271), new Guid("0da985ec-8521-4450-91aa-38020708febf"), "Eum libero et sunt aspernatur." },
                    { new Guid("fc3d5c14-9c9f-4d1b-a650-c795e73b3371"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5618), new Guid("38cd985d-281d-4b97-8c76-02c744d93921"), "Et quos quia cum." },
                    { new Guid("fda9fbd1-4dd9-4afe-bc47-deb121ea1fd9"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5733), new Guid("5456b3b0-c1fc-4df0-aea5-eb32db42eae2"), "Qui aliquam ipsa velit deserunt cum sed." },
                    { new Guid("ff819bd8-c8d0-4697-a5c6-49019cb818aa"), new DateTime(2022, 11, 27, 19, 31, 47, 468, DateTimeKind.Utc).AddTicks(5972), new Guid("8428159b-2477-401a-ba3f-e81f56d93092"), "Ut corrupti ea labore dolor est numquam voluptatem." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RestaurantId",
                table: "Employees",
                column: "RestaurantId");
        }
    }
}
