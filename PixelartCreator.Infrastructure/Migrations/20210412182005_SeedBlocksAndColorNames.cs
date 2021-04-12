using Microsoft.EntityFrameworkCore.Migrations;

namespace PixelartCreator.Infrastructure.Migrations
{
    public partial class SeedBlocksAndColorNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)56, (byte)178, "GRASS", (byte)127 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)163, (byte)233, "SAND", (byte)247 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)199, (byte)199, "WOOL", (byte)199 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)0, (byte)0, "FIRE", (byte)255 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)255, (byte)160, "ICE", (byte)160 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)167, (byte)167, "METAL", (byte)167 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)0, (byte)124, "PLANT", (byte)0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)255, (byte)255, "SNOW", (byte)255 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)184, (byte)168, "CLAY", (byte)164 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)77, (byte)109, "DIRT", (byte)151 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)112, (byte)112, "STONE", (byte)112 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)255, (byte)64, "WATER", (byte)64 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)72, (byte)119, "WOOD", (byte)143 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)245, (byte)252, "QUARTZ", (byte)255 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)51, (byte)127, "COLOR_ORANGE", (byte)216 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "G", "Name", "R" },
                values: new object[] { (byte)76, "COLOR_MAGENTA", (byte)178 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)216, (byte)153, "COLOR_LIGHT_BLUE", (byte)102 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)51, (byte)229, "COLOR_YELLOW", (byte)229 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)25, (byte)204, "COLOR_LIGHT_GREEN", (byte)127 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)165, (byte)127, "COLOR_PINK", (byte)242 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)76, (byte)76, "COLOR_GRAY", (byte)76 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "G", "Name", "R" },
                values: new object[] { (byte)153, "COLOR_LIGHT_GRAY", (byte)153 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)153, (byte)127, "COLOR_CYAN", (byte)76 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "G", "Name", "R" },
                values: new object[] { (byte)63, "COLOR_PURPLE", (byte)127 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "B", "Name", "R" },
                values: new object[] { (byte)178, "COLOR_BLUE", (byte)51 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "G", "Name" },
                values: new object[] { (byte)76, "COLOR_BROWN" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "G", "Name", "R" },
                values: new object[] { (byte)127, "COLOR_GREEN", (byte)102 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)51, (byte)51, "COLOR_RED", (byte)153 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)25, (byte)25, "COLOR_BLACK", (byte)25 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)77, (byte)238, "GOLD", (byte)250 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)213, (byte)219, "DIAMOND", (byte)92 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)255, (byte)128, "LAPIS", (byte)74 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)58, (byte)217, "EMERALD", (byte)0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)49, (byte)86, "PODZOL", (byte)129 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)0, (byte)2, "NETHER", (byte)112 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)161, (byte)177, "TERRACOTTA_WHITE", (byte)209 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)36, (byte)82, "TERRACOTTA_ORANGE", (byte)159 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)108, (byte)87, "TERRACOTTA_MAGENTA", (byte)149 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)138, (byte)108, "TERRACOTTA_LIGHT_BLUE", (byte)112 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)36, (byte)133, "TERRACOTTA_YELLOW", (byte)186 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)53, (byte)117, "TERRACOTTA_LIGHT_GREEN", (byte)103 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)78, (byte)77, "TERRACOTTA_PINK", (byte)160 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)35, (byte)41, "TERRACOTTA_GRAY", (byte)57 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)98, (byte)107, "TERRACOTTA_LIGHT_GRAY", (byte)135 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)92, (byte)92, "TERRACOTTA_CYAN", (byte)87 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)88, (byte)73, "TERRACOTTA_PURPLE", (byte)122 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "B", "G", "Name" },
                values: new object[] { (byte)92, (byte)62, "TERRACOTTA_BLUE" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "B", "G", "Name" },
                values: new object[] { (byte)35, (byte)50, "TERRACOTTA_BROWN" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)42, (byte)82, "TERRACOTTA_GREEN", (byte)76 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)46, (byte)60, "TERRACOTTA_RED", (byte)142 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)16, (byte)22, "TERRACOTTA_BLACK", (byte)37 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)49, (byte)48, "CRIMSON_NYLIUM", (byte)189 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)97, (byte)63, "CRIMSON_STEM", (byte)148 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)29, (byte)25, "CRIMSON_HYPHAE", (byte)92 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)134, (byte)126, "WARPED_NYLIUM", (byte)22 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)140, (byte)142, "WARPED_STEM", (byte)58 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "B", "G", "Name", "R" },
                values: new object[] { (byte)62, (byte)44, "WARPED_HYPHAE", (byte)86 });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "A", "B", "G", "Name", "R" },
                values: new object[] { 59, (byte)255, (byte)133, (byte)180, "WARPED_WART_BLOCK", (byte)20 });

            migrationBuilder.InsertData(
                table: "MinecraftBlocks",
                columns: new[] { "Id", "ColorId", "Name", "TexturePath" },
                values: new object[,]
                {
                    { 58, 19, "Horn Coral (Coral Block, Coral, Coral Fan), Bee Nest", null },
                    { 32, 12, "stairs), Cobblestone (slab", null },
                    { 33, 12, "stairs), Bedrock, Gold Ore, Iron Ore, Coal Ore, Lapis Lazuli Ore, Dispenser, Mossy Cobblestone (slab", null },
                    { 34, 12, "stairs", null },
                    { 35, 12, "wall), Spawner, Diamond Ore, Furnace, Stone Pressure Plate, Redstone Ore, Stone Bricks (all variants", null },
                    { 36, 12, "all slabs", null },
                    { 37, 12, "all stairs", null },
                    { 38, 12, "all walls), Emerald Ore, Ender Chest, Dropper, Smooth Stone (slab", null },
                    { 39, 12, "stairs), Observer, Smoker, Blast Furnace, Stonecutter, Sticky Piston, Piston, Piston Head, Gravel", null },
                    { 40, 12, "Acacia Log (side), Cauldron, Hopper", null },
                    { 41, 13, "Kelp, Seagrass, Water, Bubble Column", null },
                    { 42, 14, "Oak (Planks, Log (vertical), Stripped Log, Wood, Stripped Wood, Sign, Door, Pressure Plate, Fence, Trapdoor, Fence Gate, Slab, Stairs), Note Block, Bookshelf, Chest, Crafting Table, Trapped Chest, Daylight Detector, Loom, Barrel, Cartography Table, Fletching Table, Lectern, Smithing Table, Composter, Bamboo Sapling, Dead Bush, Petrified Oak Slab, Beehive", null },
                    { 43, 15, "Diorite, Polished Diorite", null },
                    { 44, 15, "Birch Log (side), Quartz Block (all variants", null },
                    { 45, 15, "all slabs", null },
                    { 46, 15, "all stairs), Sea Lantern, Target", null },
                    { 47, 16, "Acacia (Planks, Log (vertical), Stripped Log, Stripped Wood, Sign, Trapdoor, Slab), Red Sand", null },
                    { 48, 16, "Orange (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Pumpkin, Carved Pumpkin, Jack o'Lantern, Terracotta, Red Sandstone (all variants", null },
                    { 49, 16, "all stairs", null },
                    { 50, 16, "all slabs", null },
                    { 51, 16, "all walls), Honey Block, Honeycomb Block", null },
                    { 52, 17, "Magenta (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Purpur (all variants", null },
                    { 53, 17, "slab", null },
                    { 54, 17, "stairs)", null },
                    { 55, 18, "Light Blue (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Soul Fire", null },
                    { 124, 58, "Warped (Hyphae, Stripped Hyphae)", null }
                });

            migrationBuilder.InsertData(
                table: "MinecraftBlocks",
                columns: new[] { "Id", "ColorId", "Name", "TexturePath" },
                values: new object[,]
                {
                    { 123, 57, "Warped (Stem, Stripped Stem, Planks, Stairs, Slab)", null },
                    { 122, 56, "Warped Nylium", null },
                    { 31, 12, "wall), Polished Andesite (slab", null },
                    { 121, 55, "Crimson (Hyphae, Stripped Hyphae)", null },
                    { 30, 12, "stairs", null },
                    { 28, 11, "Jungle Log (vertical), Jungle Stripped Log, Jungle Wood, Jungle Stripped Wood, Jungle Sign, Jungle Pressure Plate, Jungle Trapdoor, Jungle Stairs, Jungle Slab, Jungle Fence Gate, Jungle Fence, Jungle Door, Jukebox, Brown Mushroom Block", null },
                    { 1, 2, "Grass Block, Slime Block", null },
                    { 2, 3, "Sand", null },
                    { 3, 3, "Birch Planks, Birch Log (vertical), Birch Stripped Log, Birch Wood, Birch Stripped Wood, Birch Sign, Birch Pressure Plate, Birch Trapdoor, Birch Stairs, Birch Slab, Birch Fence Gate, Birch Fence, Birch Door, Sandstone", null },
                    { 4, 3, "Sandstone slabs", null },
                    { 5, 3, "Sandstone stairs", null },
                    { 6, 3, "Sandstone walls, Glowstone, End Stone, End Stone Bricks, End Stone Bricks slab", null },
                    { 7, 3, "End Stone Bricks stairs", null },
                    { 8, 3, "End Stone Bricks wall, Bone Block, Turtle Egg, Scaffolding", null },
                    { 9, 4, "Cobweb, Mushroom Stem, Bed (head)", null },
                    { 10, 5, "Lava, TNT, Fire, Redstone Block", null },
                    { 11, 6, "Ice, Frosted Ice, Packed Ice, Blue Ice", null },
                    { 12, 7, "Block of Iron, Iron Door, Brewing Stand, Heavy Weighted Pressure Plate, Iron Trapdoor, Lantern, Anvil, Grindstone, Soul Fire Lantern, Lodestone", null },
                    { 13, 8, "Sapling, Flowers, Wheat, Sugar Cane, Pumpkin Stem, Melon Stem, Lily Pad, Cocoa, Carrots, Potatoes, Beetroots, Sweet Berry Bush, Grass, Fern, Vines, Leaves, Cactus, Bamboo", null },
                    { 14, 9, "Snow, Snow Block", null },
                    { 15, 9, "White Bed (foot), White Wool, White Stained Glass, White Carpet, White Banner, White Shulker Box, White Glazed Terracotta, White Concrete, White Concrete Powder", null },
                    { 16, 10, "Clay, Infested Stone", null },
                    { 17, 10, "Infested Cobblestone", null },
                    { 18, 10, "Infested Stone Brick", null },
                    { 19, 10, "Infested Mossy Stone Brick", null },
                    { 20, 10, "Infested Cracked Stone Brick", null },
                    { 21, 10, "Infested Chiseled Stone Brick", null },
                    { 22, 11, "Dirt, Coarse Dirt, Farmland, Grass Path, Granite, Granite slab", null },
                    { 23, 11, "Granite stairs", null },
                    { 24, 11, "Granite wall, Polished Granite", null },
                    { 25, 11, "Polished Granite slab", null },
                    { 26, 11, "Polished Granite stairs", null },
                    { 27, 11, "Jungle Planks", null },
                    { 29, 12, "Stone (slab, stairs), Andesite (slab", null },
                    { 120, 54, "Crimson (Stem, Stripped Stem, Planks, Stairs, Slab)", null },
                    { 119, 53, "Crimson Nylium", null },
                    { 118, 52, "Black Terracotta", null },
                    { 85, 32, "Block of Diamond, Beacon, Prismarine Bricks (slab", null },
                    { 84, 31, "Block of Gold, Light Weighted Pressure Plate, Bell", null },
                    { 83, 30, "Black (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Obsidian, End Portal, Dragon Egg, Coal Block, End Gateway, Basalt, Polished Basalt, Block of Netherite, Ancient Debris, Crying Obsidian, Respawn Anchor, Blackstone, Polished Blackstone, Polished Blackstone Bricks, Gilded Blackstone", null },
                    { 82, 29, "Fire Coral (Coral Block, Coral, Coral Fan), Red Mushroom, Shroomlight", null },
                    { 81, 29, "wall), Red Mushroom Block, Nether Wart, Enchanting Table, Nether Wart Block", null }
                });

            migrationBuilder.InsertData(
                table: "MinecraftBlocks",
                columns: new[] { "Id", "ColorId", "Name", "TexturePath" },
                values: new object[,]
                {
                    { 80, 29, "stairs", null },
                    { 79, 29, "Red (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Bricks (slab", null },
                    { 78, 28, "Green (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), End Portal Frame, Chain Command Block, Dried Kelp Block, Sea Pickle", null },
                    { 77, 27, "Brown (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Soul Sand, Command Block, Brown Mushroom, Soul Soil", null },
                    { 76, 27, "Spruce Log (side)", null },
                    { 75, 27, "Dark Oak (Planks, Log, Stripped Log, Wood, Stripped Wood, Sign, Pressure Plate, Trapdoor, Stairs, Slab, Fence Gate, Fence, Door)", null },
                    { 74, 26, "Tube Coral (Coral Block, Coral, Coral Fan)", null },
                    { 73, 26, "Blue (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder)", null },
                    { 72, 25, "Bubble Coral (Coral Block, Coral, Coral Fan)", null },
                    { 71, 25, "Purple (Wool, Carpet, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Mycelium, Chorus Plant, Chorus Flower, Repeating Command Block", null },
                    { 70, 25, "Shulker Box", null },
                    { 69, 24, "Warped (Roots, Pressure Plate, Fence, Trapdoor, Fence Gate, Door, Sign, Fungus), Twisting Vines, Nether Sprouts", null },
                    { 68, 24, "wall)", null },
                    { 67, 24, "stairs", null },
                    { 66, 24, "Cyan (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Prismarine (slab", null },
                    { 65, 23, "Light Gray (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Structure Block, Jigsaw Block", null },
                    { 64, 22, "Dead Coral (Coral Block, Coral, Coral Fan)", null },
                    { 63, 22, "Gray (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder)", null },
                    { 62, 22, "Acacia Wood", null },
                    { 61, 21, "Brain Coral (Coral Block, Coral, Coral Fan)", null },
                    { 60, 21, "Pink (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder)", null },
                    { 59, 20, "Lime (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Melon", null },
                    { 86, 32, "stairs), Dark Prismarine (slab", null },
                    { 87, 32, "stairs), Conduit", null },
                    { 88, 33, "Lapis Lazuli Block", null },
                    { 89, 34, "Block of Emerald", null },
                    { 117, 51, "Red Terracotta", null },
                    { 116, 50, "Green Terracotta", null },
                    { 115, 49, "Brown Terracotta", null },
                    { 114, 48, "Blue Terracotta", null },
                    { 113, 47, "Purple (Terracotta, Shulker Box)", null },
                    { 112, 46, "Cyan Terracotta", null },
                    { 111, 45, "Light Gray Terracotta", null },
                    { 110, 44, "Gray Terracotta", null },
                    { 109, 43, "Pink Terracotta", null },
                    { 108, 42, "Lime Terracotta", null },
                    { 107, 41, "Yellow Terracotta", null },
                    { 106, 40, "Light Blue Terracotta", null },
                    { 105, 39, "Magenta Terracotta", null },
                    { 57, 19, "Yellow (Wool, Carpet, Shulker Box, Bed (foot), Stained Glass, Banner, Glazed Terracotta, Concrete, Concrete Powder), Hay Bale", null },
                    { 104, 38, "Orange Terracotta", null },
                    { 102, 36, "Crimson (Roots, Pressure Plate, Fence, Trapdoor, Fence Gate, Door, Sign, Fungus), Weeping Vines", null }
                });

            migrationBuilder.InsertData(
                table: "MinecraftBlocks",
                columns: new[] { "Id", "ColorId", "Name", "TexturePath" },
                values: new object[,]
                {
                    { 101, 36, "wall)", null },
                    { 100, 36, "stairs", null },
                    { 99, 36, "cracked), Nether Gold Ore, Nether Quartz Ore, Magma Block, Red Nether Bricks (slab", null },
                    { 98, 36, "chiseled", null },
                    { 97, 36, "wall", null },
                    { 96, 36, "stairs", null },
                    { 95, 36, "slab", null },
                    { 94, 36, "Netherrack, Nether Bricks (fence", null },
                    { 93, 35, "Jungle Log (side), Campfire, Soul Campfire", null },
                    { 92, 35, "Oak Log (side)", null },
                    { 91, 35, "Spruce (Planks, Log (vertical), Stripped Log, Wood, Stripped Wood, Sign, Pressure Plate, Trapdoor, Stairs, Slab, Fence Gate, Fence, Door)", null },
                    { 56, 19, "Sponge, Wet Sponge", null },
                    { 103, 37, "White Terracotta", null },
                    { 90, 35, "Podzol", null }
                });

            migrationBuilder.InsertData(
                table: "MinecraftBlocks",
                columns: new[] { "Id", "ColorId", "Name", "TexturePath" },
                values: new object[] { 125, 59, "Warped Wart Block", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "MinecraftBlocks",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Colors");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)163, (byte)233, (byte)247 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)199, (byte)199, (byte)199 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)0, (byte)0, (byte)255 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)255, (byte)160, (byte)160 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)167, (byte)167, (byte)167 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)0, (byte)124, (byte)0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)255, (byte)255, (byte)255 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)184, (byte)168, (byte)164 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)77, (byte)109, (byte)151 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)112, (byte)112, (byte)112 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)255, (byte)64, (byte)64 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)72, (byte)119, (byte)143 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)245, (byte)252, (byte)255 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)51, (byte)127, (byte)216 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)216, (byte)76, (byte)178 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "G", "R" },
                values: new object[] { (byte)153, (byte)102 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)51, (byte)229, (byte)229 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)25, (byte)204, (byte)127 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)165, (byte)127, (byte)242 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)76, (byte)76, (byte)76 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)153, (byte)153, (byte)153 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "G", "R" },
                values: new object[] { (byte)127, (byte)76 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)178, (byte)63, (byte)127 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "G", "R" },
                values: new object[] { (byte)76, (byte)51 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "B", "R" },
                values: new object[] { (byte)51, (byte)102 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 27,
                column: "G",
                value: (byte)127);

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "G", "R" },
                values: new object[] { (byte)51, (byte)153 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)25, (byte)25, (byte)25 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)77, (byte)238, (byte)250 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)213, (byte)219, (byte)92 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)255, (byte)128, (byte)74 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)58, (byte)217, (byte)0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)49, (byte)86, (byte)129 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)0, (byte)2, (byte)112 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)161, (byte)177, (byte)209 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)36, (byte)82, (byte)159 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)108, (byte)87, (byte)149 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)138, (byte)108, (byte)112 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)36, (byte)133, (byte)186 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)53, (byte)117, (byte)103 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)78, (byte)77, (byte)160 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)35, (byte)41, (byte)57 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)98, (byte)107, (byte)135 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)92, (byte)92, (byte)87 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)88, (byte)73, (byte)122 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)92, (byte)62, (byte)76 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "B", "G" },
                values: new object[] { (byte)35, (byte)50 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "B", "G" },
                values: new object[] { (byte)42, (byte)82 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)46, (byte)60, (byte)142 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)16, (byte)22, (byte)37 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)49, (byte)48, (byte)189 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)97, (byte)63, (byte)148 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)29, (byte)25, (byte)92 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)134, (byte)126, (byte)22 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)140, (byte)142, (byte)58 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)62, (byte)44, (byte)86 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "B", "G", "R" },
                values: new object[] { (byte)133, (byte)180, (byte)20 });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "A", "B", "G", "R" },
                values: new object[] { 1, (byte)255, (byte)56, (byte)178, (byte)127 });
        }
    }
}
