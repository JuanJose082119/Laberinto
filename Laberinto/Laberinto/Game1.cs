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
        Texture2D Balon, Pared_lateral, Pared_Abajo, Pared_Arriba, Pared_LateralIz, Pared_LateralDe, Pared2, Pared3, Pared4, Pared5;
        Texture2D Pared6, Pared7, Pared8, Pared9, Pared10, Pared11, Pared12, Pared13, Pared14, Pared15;

        //Rectangulos
        Rectangle Posicion_ParedAbajo, Posicion_Balon, Posicion_Pared1, Posicion_ParedArriba, Posicion_ParedLateralIz, Posicion_ParedLateralDe, Posicion_Pared2;
        Rectangle Posicion_Pared3, Posicion_Pared4, Posicion_Pared5, Posicion_Pared6, Posicion_Pared7, Posicion_Pared8, Posicion_Pared9, Posicion_Pared10, Posicion_Pared11;
        Rectangle Posicion_Pared12, Posicion_Pared13, Posicion_Pared14, Posicion_Pared15;

        byte r, g, b;
        int VelocidadBalon;
        
        void ManejoPorTeclado()
        {
            KeyboardState EstadoTeclado = Keyboard.GetState();
            //Presionar Escape para salir
            if (EstadoTeclado.IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            //Mover hacia la izquierda
            if (EstadoTeclado.IsKeyDown(Keys.Left))
            {
                Posicion_Balon.X -= VelocidadBalon;
            }
            //Mover hacia la derecha
            if(EstadoTeclado.IsKeyDown(Keys.Right))
            {
                Posicion_Balon.X += VelocidadBalon;
            }
            //Mover hacia arriba
            if(EstadoTeclado.IsKeyDown(Keys.Up))
            {
                Posicion_Balon.Y -= VelocidadBalon;
            }
            //Mover hacia abajo
            if(EstadoTeclado.IsKeyDown(Keys.Down))
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
            Posicion_ParedLateralDe = new Rectangle(780, 0, 20, 780);
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
            Posicion_Pared15 = new Rectangle(290, 300, 70, 20);
            VelocidadBalon = 2;
            r = 190;
            g = 20;
            b = 80;
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
            if (Posicion_Balon.Intersects(Posicion_Pared1) || Posicion_Balon.X >= 760 || Posicion_Balon.X <= 0 || Posicion_Balon.Y <= 0 || Posicion_Balon.Intersects(Posicion_Pared14) ||
                Posicion_Balon.Y >= 440 ||  Posicion_Balon.Intersects(Posicion_Pared15) || Posicion_Balon.Intersects(Posicion_ParedAbajo) || Posicion_Balon.Intersects(Posicion_ParedArriba)
                || Posicion_Balon.Intersects(Posicion_ParedLateralIz) || Posicion_Balon.Intersects(Posicion_ParedLateralDe) || Posicion_Balon.Intersects(Posicion_Pared2))
            {
                Teclado2();
                r ++;
                g ++;
                b ++;
            }
            
            if(Posicion_Balon.Intersects(Posicion_Pared3) || Posicion_Balon.Intersects(Posicion_Pared4) || Posicion_Balon.Intersects(Posicion_Pared5) || Posicion_Balon.Intersects(Posicion_Pared6)
                || Posicion_Balon.Intersects(Posicion_Pared7) || Posicion_Balon.Intersects(Posicion_Pared8) || Posicion_Balon.Intersects(Posicion_Pared9) || Posicion_Balon.Intersects(Posicion_Pared10)
                || Posicion_Balon.Intersects(Posicion_Pared11) || Posicion_Balon.Intersects(Posicion_Pared12) || Posicion_Balon.Intersects(Posicion_Pared13))
            {
                Teclado2();
                r ++;
                g ++;
                b ++;
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            Color miColor = new Color(r, g, b);
            GraphicsDevice.Clear(miColor);
            
            spriteBatch.Begin();
            spriteBatch.Draw(Balon, Posicion_Balon, Color.White);
            spriteBatch.Draw(Pared_lateral, Posicion_Pared1, Color.White);
            spriteBatch.Draw(Pared_Abajo, Posicion_ParedAbajo, Color.White);
            spriteBatch.Draw(Pared_Arriba, Posicion_ParedArriba, Color.White);
            spriteBatch.Draw(Pared_LateralIz, Posicion_ParedLateralIz, Color.White);
            spriteBatch.Draw(Pared_LateralDe, Posicion_ParedLateralDe, Color.White);
            spriteBatch.Draw(Pared2, Posicion_Pared2, Color.White);
            spriteBatch.Draw(Pared3, Posicion_Pared3, Color.White);
            spriteBatch.Draw(Pared4, Posicion_Pared4, Color.White);
            spriteBatch.Draw(Pared5, Posicion_Pared5, Color.White);
            spriteBatch.Draw(Pared6, Posicion_Pared6, Color.White);
            spriteBatch.Draw(Pared7, Posicion_Pared7, Color.White);
            spriteBatch.Draw(Pared8, Posicion_Pared8, Color.White);
            spriteBatch.Draw(Pared9, Posicion_Pared9, Color.White);
            spriteBatch.Draw(Pared10, Posicion_Pared10, Color.White);
            spriteBatch.Draw(Pared11, Posicion_Pared11, Color.White);
            spriteBatch.Draw(Pared12, Posicion_Pared12, Color.White);
            spriteBatch.Draw(Pared13, Posicion_Pared13, Color.White);
            spriteBatch.Draw(Pared14, Posicion_Pared14, Color.White);
            spriteBatch.Draw(Pared15, Posicion_Pared15, Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
