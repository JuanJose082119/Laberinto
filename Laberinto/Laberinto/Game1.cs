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
        Texture2D Pared6;

        //Rectangulos
        Rectangle Posicion_ParedAbajo, Posicion_Balon, Posicion_Pared1, Posicion_ParedArriba, Posicion_ParedLateralIz, Posicion_ParedLateralDe, Posicion_Pared2;
        Rectangle Posicion_Pared3, Posicion_Pared4, Posicion_Pared5, Posicion_Pared6;

        
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

            Posicion_Balon = new Rectangle(0, 21, 35, 35);
            Posicion_Pared1 = new Rectangle(0, 120, 60, 20);
            Posicion_ParedAbajo = new Rectangle(0, 460, 800, 20);
            Posicion_ParedArriba = new Rectangle(0, 0, 800, 20);
            Posicion_ParedLateralIz = new Rectangle(0, 60, 20, 750);
            Posicion_ParedLateralDe = new Rectangle(780, 0, 20, 780);
            Posicion_Pared2 = new Rectangle(60, 60, 20, 80);
            Posicion_Pared3 = new Rectangle(130, 60, 20, 140);
            Posicion_Pared4 = new Rectangle(60, 180, 180, 20);
            Posicion_Pared5 = new Rectangle(60, 180, 20, 80);
            Posicion_Pared6 = new Rectangle(60, 245, 100, 20);
            VelocidadBalon = 2;
            //Hola
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
            if (Posicion_Balon.Intersects(Posicion_Pared1) || Posicion_Balon.X >= 760 || Posicion_Balon.X <= 0 || Posicion_Balon.Y <= 0 ||
                Posicion_Balon.Y >= 440 || Posicion_Balon.Intersects(Posicion_ParedAbajo) || Posicion_Balon.Intersects(Posicion_ParedArriba)
                || Posicion_Balon.Intersects(Posicion_ParedLateralIz) || Posicion_Balon.Intersects(Posicion_ParedLateralDe) || Posicion_Balon.Intersects(Posicion_Pared2))
            {
                Teclado2();
            }
            
            if(Posicion_Balon.Intersects(Posicion_Pared3) || Posicion_Balon.Intersects(Posicion_Pared4) || Posicion_Balon.Intersects(Posicion_Pared5) || Posicion_Balon.Intersects(Posicion_Pared6))
            {
                Teclado2();
            }
                
           
            



        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
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
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
