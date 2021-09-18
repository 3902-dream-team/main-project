﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project1.Command;
using Project1.Controller;
using Project1.LinkComponents;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public ILink Link;
        private IController keyboard;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            keyboard = new KeyboardController();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // Requirement - Arrow and "wasd" keys should move Link and change his facing direction.
            keyboard.RegisterCommand(new LinkMoveUpCmd(this), Keys.W);
            keyboard.RegisterCommand(new LinkMoveDownCmd(this), Keys.S);
            keyboard.RegisterCommand(new LinkMoveRightCmd(this), Keys.D);
            keyboard.RegisterCommand(new LinkMoveLeftCmd(this), Keys.A);

            keyboard.RegisterCommand(new LinkMoveUpCmd(this), Keys.Up);
            keyboard.RegisterCommand(new LinkMoveDownCmd(this), Keys.Down);
            keyboard.RegisterCommand(new LinkMoveRightCmd(this), Keys.Right);
            keyboard.RegisterCommand(new LinkMoveLeftCmd(this), Keys.Left);

            keyboard.RegisterCommand(new LinkSwordAttackCmd(this), Keys.Z);
            keyboard.RegisterCommand(new LinkSwordAttackCmd(this), Keys.N);

            /* Requirement - The 'z' and 'n' key should cause Link to attack using his sword. 
             * Number keys(1, 2, 3, etc.) should be used to have Link use a different item(later 
             *  this will be replaced with a menu system and 'x' and 'm' for the secondary item. 
             * Use 'e' to cause Link to become damaged
            */

            /* Requirement - Use keys "t" and "y" to cycle between which block is currently being 
             * shown (i.e. think of the obstacles as being in a list where the game's current 
             * obstacle is being drawn, "t" switches to the previous item and "y" switches to the next)
             */

            /* Requirement - Use keys "u" and "i" to cycle between which item is currently being shown 
             * (i.e. think of the items as being in a list where the game's current item is being drawn, 
             * "u" switches to the previous item and "i" switches to the next)
             * Items should move and animate as they do in the final game, but should not interact with any other objects
             */

            /* Requirement - Use keys "o" and "p" to cycle between which enemy or npc is currently being shown 
             * (i.e. think of these characters as being in a list where the game's current character is being drawn, 
             * "o" switches to the previous item and "p" switches to the next)
             * characters should move, animate, fire projectiles, etc. as they do in the final game, but should not 
             * interact with any other objects
             */

            /* Requirement - Use 'q' to quit 
             * and 'r' to reset the program back to its initial state.
             */
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
