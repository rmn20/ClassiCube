﻿// Copyright 2014-2017 ClassicalSharp | Licensed under BSD-3
using System;
using BlockID = System.UInt16;

namespace ClassicalSharp.Events {

	public class UserEvents : EventsBase {
        
        //BlockChanging event_here; // ??
		
		/// <summary> Raised when the user changes a block in the world. </summary>
		public event EventHandler<BlockChangedEventArgs> BlockChanged;
		public void RaiseBlockChanged(Vector3I coords, BlockID old, BlockID block) {
			blockArgs.Coords = coords; blockArgs.OldBlock = old; blockArgs.Block = block; 
			Raise(BlockChanged, blockArgs);
		}
	
		BlockChangedEventArgs blockArgs = new BlockChangedEventArgs();
	}
	
	public sealed class BlockChangedEventArgs : EventArgs {
		public Vector3I Coords;
		public BlockID OldBlock;
		public BlockID Block;
	}
}
