using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Laberinto
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //Texturas
        Texture2D Inicio, Fondo, Balon, Pared_lateral, Pared_Abajo, Pared_Arriba, Pared_LateralIz, Pared_LateralDe, Pared2, Pared3, Pared4, Pared5,Pared6, Pared7, Pared8, Pared9, Pared10, Pared11, Pared12, Pared13, Pared14, Pared15, Pared16, Pared17, Pared18, Pared19;
        Texture2D Pared20, GameOver, Pared21, Pared22, Pared23, Pared24, Pared25, Pared26, Pared27, Pared28, Pared29, Pared30, Pared31;
        //Rectangulos
        Rectangle Pos_Inicio, Pos_Fondo, Posicion_ParedAbajo, Posicion_Balon, Posicion_Pared1, Posicion_ParedArriba, Posicion_ParedLateralIz, Posicion_ParedLateralDe, Posicion_Pared2, Pos_Pared21, Pos_Pared22, Pos_Pared23, Pos_Pared24, Pos_Pared25;
        Rectangle Posicion_Pared3, Posicion_Pared4, Posicion_Pared5, Posicion_Pared6, Posicion_Pared7, Posicion_Pared8, Posicion_Pared9, Posicion_Pared10, Posicion_Pared11, Pos_Pared26, Pos_Pared27, Pos_Pared28, Pos_Pared29, Pos_Pared30, Pos_Pared31;
        Rectangle Posicion_Pared12, Posicion_Pared13, Posicion_Pared14, Posicion_Pared15, Posicion_Pared16, Posicion_Pared17, Posicion_Pared18, Pos_Pared19, Pos_Pared20, Pos_Over;

        
        int VelocidadBalon;
        bool Colision;
        bool inicio;
       

        void ManejoPorTeclado()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Posicion_Balon.X -= VelocidadBalon;
            }
            //Mover hacia la derecha
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Posicion_Balon.X += VelocidadBalon;
            }
            //Mover hacia arriba
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Posicion_Balon.Y -= VelocidadBalon;
            }
            //Mover hacia abajo
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Posicion_Balon.Y += VelocidadBalon;
            }
        }


        void Teclado2()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Posicion_Balon.X += VelocidadBalon;
            }
            //Mover hacia la derecha
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Posicion_Balon.X -= VelocidadBalon;
            }
            //Mover hacia arriba
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Posicion_Balon.Y += VelocidadBalon;
            }
            //Mover hacia abajo
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Posicion_Balon.Y -= VelocidadBalon;
            }
        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            Posicion_Balon = new Rectangle(2, 25, 35, 35);
            Posicion_Pared1 = new Rectangle(0, 120, 60, 20);
            Posicion_ParedAbajo = new Rectangle(0, 460, 800, 20);
            Posicion_ParedArriba = new Rectangle(0, 0, 800, 20);
            Posicion_ParedLateralIz = new Rectangle(0, 70, 20, 750);
            Posicion_ParedLateralDe = new Rectangle(780, 0, 20, 750);
            Posicion_Pared2 = new Rectangle(60, 60, 20, 80);
            Posicion_Pared3 = new Rectangle(130, 60, 20, 140);
            Posicion_Pared4 = new Rectangle(60, 180, 180, 20);
            Posicion_Pared5 = new Rectangle(60, 180, 20, 80);
            Posicion_Pared6 = new Rectangle(60, 245, 100, 20);
            Posicion_Pared7 = new Rectangle(140, 245, 20, 175);
            Posicion_Pared8 = new Rectangle(0, 310, 90, 20);
            Posicion_Pared9 = new Rectangle(80, 310, 20, 110);
            Posicion_Pared10 = new Rectangle(220, 180, 20, 310);
            Posicion_Pared11 = new Rectangle(220, 0, 20, 120);
            Posicion_Pared12 = new Rectangle(220, 120, 80, 20);
            Posicion_Pared13 = new Rectangle(290, 70, 20, 180);
            Posicion_Pared14 = new Rectangle(290, 300, 20, 200);
            Posicion_Pared15 = new Rectangle(290, 300, 80, 20);
            Posicion_Pared16 = new Rectangle(350, 360, 20, 100);
            Posicion_Pared17 = new Rectangle(350, 0, 20, 250);
            Posicion_Pared18 = new Rectangle(350, 230, 70, 20);
            Pos_Pared19 = new Rectangle(420, 60, 20, 190);
            Pos_Pared20 = new Rectangle(420, 300, 20, 120);
            Pos_Pared21 = new Rectangle(420, 400, 160, 20);
            Pos_Pared22 = new Rectangle(420, 300, 100, 20);
            Pos_Pared23 = new Rectangle(500, 0, 20, 300);
            Pos_Pared24 = new Rectangle(560, 60, 20, 290);
            Pos_Pared25 = new Rectangle(560, 330, 80, 20);
            Pos_Pared26 = new Rectangle(640, 330, 20, 130);
            Pos_Pared27 = new Rectangle(560, 60, 170, 20);
            Pos_Pared28 = new Rectangle(710, 60, 20, 220);
            Pos_Pared29 = new Rectangle(620, 260, 90, 20);
            Pos_Pared30 = new Rectangle(620, 120, 20, 140);
            Pos_Pared31 = new Rectangle(700, 350, 80, 20);
            Pos_Over = new Rectangle(200, 60, 400, 400);
            Pos_Inicio = new Rectangle(0, 0, 800, 480);
            Pos_Fondo = new Rectangle(0, 0, 800, 480);
            

            VelocidadBalon = 4;
            Colision = false;
            inicio = false;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Balon = Content.Load<Texture2D>("Balon");
            Pared_lateral = Content.Load<Texture2D>("Pared1");
            Pared_Abajo = Content.Load<Texture2D>("Pared_Abajo");
            Pared_Arriba = Content.Load<Texture2D>("Pared_Arriba");
            Pared_LateralIz = Content.Load<Texture2D>("Pared_lateral");
            Pared_LateralDe = Content.Load<Texture2D>("Pared_lateral2");
            Pared2 = Content.Load<Texture2D>("Pared2");
            Pared3 = Content.Load<Texture2D>("Pared3");
            Pared4 = Content.Load<Texture2D>("Pared4");
            Pared5 = Content.Load<Texture2D>("Pared5");
            Pared6 = Content.Load<Texture2D>("Pared6");
            Pared7 = Content.Load<Texture2D>("Pared7");
            Pared8 = Content.Load<Texture2D>("Pared8");
            Pared9 = Content.Load<Texture2D>("Pared9");
            Pared10 = Content.Load<Texture2D>("Pared10");
            Pared11 = Content.Load<Texture2D>("Pared11");
            Pared12 = Content.Load<Texture2D>("Pared12");
            Pared13 = Content.Load<Texture2D>("Pared13");
            Pared14 = Content.Load<Texture2D>("Pared14");
            Pared15 = Content.Load<Texture2D>("Pared15");
            Pared16 = Content.Load<Texture2D>("Pared16");
            Pared17 = Content.Load<Texture2D>("Pared17");
            Pared18 = Content.Load<Texture2D>("Pared18");
            Pared19 = Content.Load<Texture2D>("Pared19");
            Pared20 = Content.Load<Texture2D>("Pared20");
            Pared21 = Content.Load<Texture2D>("Pared21");
            Pared22 = Content.Load<Texture2D>("Pared22");
            Pared23 = Content.Load<Texture2D>("Pared23");
            Pared24 = Content.Load<Texture2D>("Pared24");
            Pared25 = Content.Load<Texture2D>("Pared25");
            Pared26 = Content.Load<Texture2D>("Pared26");
            Pared27 = Content.Load<Texture2D>("Pared27");
            Pared28 = Content.Load<Texture2D>("Pared28");
            Pared29 = Content.Load<Texture2D>("Pared29");
            Pared30 = Content.Load<Texture2D>("Pared30");
            Pared31 = Content.Load<Texture2D>("Pared31");
            GameOver = Content.Load<Texture2D>("Game Over");
            Inicio = Content.Load<Texture2D>("Estadio1");
            Fondo = Content.Load<Texture2D>("Arco");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //Función de los movimientos por teclado
            ManejoPorTeclado();

            //Colisión
            if (Posicion_Balon.Intersects(Posicion_Pared1) || Posicion_Balon.Intersects(Posicion_Pared14) || Posicion_Balon.Intersects(Posicion_Pared16) || Posicion_Balon.Intersects(Pos_Pared20) || Posicion_Balon.Intersects(Pos_Pared21) || Posicion_Balon.Intersects(Pos_Pared22) || Posicion_Balon.Intersects(Pos_Pared24) ||
                Posicion_Balon.Intersects(Posicion_Pared17) || Posicion_Balon.Intersects(Pos_Pared19) || Posicion_Balon.Intersects(Posicion_Pared18) || Posicion_Balon.Intersects(Posicion_Pared15) || Posicion_Balon.Intersects(Posicion_ParedAbajo) || Posicion_Balon.Intersects(Posicion_ParedArriba) || Posicion_Balon.Intersects(Pos_Pared25) 
                || Posicion_Balon.Intersects(Posicion_ParedLateralIz) || Posicion_Balon.Intersects(Posicion_ParedLateralDe) || Posicion_Balon.Intersects(Posicion_Pared2) || Posicion_Balon.Intersects(Pos_Pared23) || Posicion_Balon.Intersects(Pos_Pared26) || Posicion_Balon.Intersects(Pos_Pared27) || Posicion_Balon.Intersects(Pos_Pared28))
            {
                Teclado2();
                Colision = true;

            }
            
            if(Posicion_Balon.Intersects(Posicion_Pared3) || Posicion_Balon.Intersects(Posicion_Pared4) || Posicion_Balon.Intersects(Posicion_Pared5) || Posicion_Balon.Intersects(Posicion_Pared6) || Posicion_Balon.Intersects(Pos_Pared29) || Posicion_Balon.Intersects(Pos_Pared30) || Posicion_Balon.Intersects(Pos_Pared31) 
                || Posicion_Balon.Intersects(Posicion_Pared7) || Posicion_Balon.Intersects(Posicion_Pared8) || Posicion_Balon.Intersects(Posicion_Pared9) || Posicion_Balon.Intersects(Posicion_Pared10)
                || Posicion_Balon.Intersects(Posicion_Pared11) || Posicion_Balon.Intersects(Posicion_Pared12) || Posicion_Balon.Intersects(Posicion_Pared13))
            {
                Teclado2();
                Colision = true;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.E))
            {
                inicio = true;
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.Black);
            
            spriteBatch.Begin();
            spriteBatch.Draw(Fondo, Pos_Fondo, Color.White);
            if (inicio == true)
            {
                spriteBatch.Draw(Balon, Posicion_Balon, Color.White);
                spriteBatch.Draw(Pared_lateral, Posicion_Pared1, Color.Black);
                spriteBatch.Draw(Pared_Abajo, Posicion_ParedAbajo, Color.Black);
                spriteBatch.Draw(Pared_Arriba, Posicion_ParedArriba, Color.Black);
                spriteBatch.Draw(Pared_LateralIz, Posicion_ParedLateralIz, Color.Black);
                spriteBatch.Draw(Pared_LateralDe, Posicion_ParedLateralDe, Color.Black);
                spriteBatch.Draw(Pared2, Posicion_Pared2, Color.Black);
                spriteBatch.Draw(Pared3, Posicion_Pared3, Color.Black);
                spriteBatch.Draw(Pared4, Posicion_Pared4, Color.Black);
                spriteBatch.Draw(Pared5, Posicion_Pared5, Color.Black);
                spriteBatch.Draw(Pared6, Posicion_Pared6, Color.Black);
                spriteBatch.Draw(Pared7, Posicion_Pared7, Color.Black);
                spriteBatch.Draw(Pared8, Posicion_Pared8, Color.Black);
                spriteBatch.Draw(Pared9, Posicion_Pared9, Color.Black);
                spriteBatch.Draw(Pared10, Posicion_Pared10, Color.Black);
                spriteBatch.Draw(Pared11, Posicion_Pared11, Color.Black);
                spriteBatch.Draw(Pared12, Posicion_Pared12, Color.Black);
                spriteBatch.Draw(Pared13, Posicion_Pared13, Color.Black);
                spriteBatch.Draw(Pared14, Posicion_Pared14, Color.Black);
                spriteBatch.Draw(Pared15, Posicion_Pared15, Color.Black);
                spriteBatch.Draw(Pared16, Posicion_Pared16, Color.Black);
                spriteBatch.Draw(Pared17, Posicion_Pared17, Color.Black);
                spriteBatch.Draw(Pared18, Posicion_Pared18, Color.Black);
                spriteBatch.Draw(Pared19, Pos_Pared19, Color.Black);
                spriteBatch.Draw(Pared20, Pos_Pared20, Color.Black);
                spriteBatch.Draw(Pared21, Pos_Pared21, Color.Black);
                spriteBatch.Draw(Pared22, Pos_Pared22, Color.Black);
                spriteBatch.Draw(Pared23, Pos_Pared23, Color.Black);
                spriteBatch.Draw(Pared24, Pos_Pared24, Color.Black);
                spriteBatch.Draw(Pared25, Pos_Pared25, Color.Black);
                spriteBatch.Draw(Pared26, Pos_Pared26, Color.Black);
                spriteBatch.Draw(Pared27, Pos_Pared27, Color.Black);
                spriteBatch.Draw(Pared28, Pos_Pared28, Color.Black);
                spriteBatch.Draw(Pared29, Pos_Pared29, Color.Black);
                spriteBatch.Draw(Pared30, Pos_Pared30, Color.Black);
                spriteBatch.Draw(Pared31, Pos_Pared31, Color.Black);
            }
            else
            {
                spriteBatch.Draw(Inicio, Pos_Inicio, Color.White);
            }
                
            
            
            
                //spriteBatch.Draw(GameOver, Pos_Over, Color.White);
            
            
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
