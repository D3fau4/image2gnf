using System.ComponentModel;
using System.IO;
using GFDLibrary;
using GFDLibrary.Materials;

namespace GFDStudio.GUI.DataViewNodes
{
    public class MaterialAttributeType2ViewNode : MaterialAttributeViewNode<MaterialAttributeType2>
    {
        public override DataViewNodeMenuFlags ContextMenuFlags =>
            DataViewNodeMenuFlags.Export | DataViewNodeMenuFlags.Replace | DataViewNodeMenuFlags.Delete;

        public override DataViewNodeFlags NodeFlags
            => DataViewNodeFlags.Leaf;

        // 0C
        [ Browsable( true ) ]
        public int Field0C
        {
            get => GetDataProperty<int>();
            set => SetDataProperty( value );
        }

        // 10
        [Browsable( true )]
        public int Field10
        {
            get => GetDataProperty<int>();
            set => SetDataProperty( value );
        }

        public MaterialAttributeType2ViewNode( string text, MaterialAttributeType2 data ) : base( text, data )
        {
        }

        protected override void InitializeCore()
        {
            RegisterExportHandler<Stream>( path => MaterialAttribute.Save( Data, path ) );
            RegisterReplaceHandler<Stream>( Resource.Load<MaterialAttributeType2> );
        }
    }
}