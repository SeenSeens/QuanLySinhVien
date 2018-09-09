using System;
using System.Collections.Generic;

using DevExpress.DXCore.Adornments;
using DevExpress.DXCore.Platform.Drawing;

using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.StructuralParser;

namespace QuanLySinhVien
{
    class rDocumentAdornment : TextDocumentAdornment
    {
        public rDocumentAdornment(SourceRange range)
          : base(range)
        {
        }

        protected override TextViewAdornment NewAdornment(string feature, IElementFrame frame)
        {
            return new rViewAdornment(feature, frame);
        }
    }

    class rViewAdornment : VisualObjectAdornment
    {
        public rViewAdornment(string feature, IElementFrame frame)
          : base(feature, frame)
        {
        }

        public override void Render(IDrawingSurface context, ElementFrameGeometry geometry)
        {
            // TODO: Add adornment painting logic
            context.DrawRectangle(null, Colors.Red, geometry.StartRect);
            context.DrawRectangle(null, Colors.Green, geometry.EndRect);
            context.DrawRectangle(null, Colors.Blue, geometry.Bounds);
        }
    }
}