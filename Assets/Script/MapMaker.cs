//using System.Drawing;

//public class MapMaker {
        
//    private int image_width = 0;
//    private int image_height = 0;

//    Bitmap tile;
//    Graphics g;
//    Image tile_img = Bitmap.FromFile("..\\Image\\asdf.png");

//    public MapMaker(int tile_width, int tile_height)
//    {
//        image_width = tile_width * 64 + tile_height * 64 + 64;
//        image_height = (tile_width > tile_height) ? tile_width * 32 + 32 : tile_height * 32 + 32;
        
//        tile = new Bitmap(image_width, image_height);
//        g = Graphics.FromImage(tile);

//        for (int i = 0; i < tile_height; i++) // 타일 이미지 배치
//        {
//            for (int j = 0; j < tile_width; j++)
//            {
//                g.DrawImage(tile_img, i * -64 + j * 64, i * 32 + j * 32);
//            }
//        }

//        tile.Save("..\\Image\\tile.png");

//        /*
//         * (0, 0), (1, 0), (2, 0),
//         * (0, 1), (1, 1), (2, 1),
//         * (0, 2), (1, 2), (2, 2)
//         */
//    }
//}