﻿namespace AngleSharp.Parser.Css
{
    using System;

    /// <summary>
    /// The base class token for the CSS parser.
    /// </summary>
    class CssToken
    {
        #region Fields

        readonly CssTokenType _type;
        readonly String _data;
        readonly TextPosition _position;

        public static readonly CssToken Whitespace = new CssToken(CssTokenType.Whitespace, " ", TextPosition.Empty);
        public static readonly CssToken Comma = new CssToken(CssTokenType.Comma, ",", TextPosition.Empty);

        #endregion

        #region ctor

        public CssToken(CssTokenType type, String data, TextPosition position)
        {
            _type = type;
            _data = data;
            _position = position;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the position of the token.
        /// </summary>
        public TextPosition Position
        {
            get { return _position; }
        }

        /// <summary>
        /// Gets the type of the token.
        /// </summary>
        public CssTokenType Type
        {
            get { return _type; }
        }

        /// <summary>
        /// Gets the data of the token.
        /// </summary>
        public String Data
        {
            get { return _data; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a string which represents the original value.
        /// </summary>
        /// <returns>The original value.</returns>
        public virtual String ToValue()
        {
            return _data;
        }

        #endregion
    }
}
