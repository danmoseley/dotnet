// Copyright (c) Microsoft Corporation.  All Rights Reserved.  See License.txt in the project root for license information.

// This file is automatically generated by IntConversionsTestGenerator.fsx    
namespace FSharp.Core.UnitTests
open System
open Xunit
open FSharp.Core.UnitTests.LibraryTestFx

module UInt8 =
    let MinValue = Byte.MinValue
    let MaxValue = Byte.MaxValue

module Int8 =
    let MinValue = SByte.MinValue
    let MaxValue = SByte.MaxValue

type IntConversionsGenerated() =

  [<Fact>]
  member this.``sbyte.m1.To.byte`` () =
    let i : sbyte = -1y
    Assert.AreEqual (Byte.MaxValue, byte i)

  [<Fact>]
  member this.``int8.m1.To.byte`` () =
    let i : int8 = -1y
    Assert.AreEqual (Byte.MaxValue, byte i)

  [<Fact>]
  member this.``int16.m1.To.byte`` () =
    let i : int16 = -1s
    Assert.AreEqual (Byte.MaxValue, byte i)

  [<Fact>]
  member this.``int32.m1.To.byte`` () =
    let i : int32 = -1l
    Assert.AreEqual (Byte.MaxValue, byte i)

  [<Fact>]
  member this.``int64.m1.To.byte`` () =
    let i : int64 = -1L
    Assert.AreEqual (Byte.MaxValue, byte i)

  [<Fact>]
  member this.``sbyte.m1.To.uint8`` () =
    let i : sbyte = -1y
    Assert.AreEqual (UInt8.MaxValue, uint8 i)

  [<Fact>]
  member this.``int8.m1.To.uint8`` () =
    let i : int8 = -1y
    Assert.AreEqual (UInt8.MaxValue, uint8 i)

  [<Fact>]
  member this.``int16.m1.To.uint8`` () =
    let i : int16 = -1s
    Assert.AreEqual (UInt8.MaxValue, uint8 i)
  
  [<Fact>]
  member this.``int32.m1.To.uint8`` () =
    let i : int32 = -1l
    Assert.AreEqual (UInt8.MaxValue, uint8 i)
  
  [<Fact>]
  member this.``int64.m1.To.uint8`` () =
    let i : int64 = -1L
    Assert.AreEqual (UInt8.MaxValue, uint8 i)
  
  [<Fact>]
  member this.``sbyte.m1.To.uint16`` () =
    let i : sbyte = -1y
    Assert.AreEqual (UInt16.MaxValue, uint16 i)
  
  [<Fact>]
  member this.``int8.m1.To.uint16`` () =
    let i : int8 = -1y
    Assert.AreEqual (UInt16.MaxValue, uint16 i)
  
  [<Fact>]
  member this.``int16.m1.To.uint16`` () =
    let i : int16 = -1s
    Assert.AreEqual (UInt16.MaxValue, uint16 i)
  
  [<Fact>]
  member this.``int32.m1.To.uint16`` () =
    let i : int32 = -1l
    Assert.AreEqual (UInt16.MaxValue, uint16 i)
  
  [<Fact>]
  member this.``int64.m1.To.uint16`` () =
    let i : int64 = -1L
    Assert.AreEqual (UInt16.MaxValue, uint16 i)
  
  [<Fact>]
  member this.``sbyte.m1.To.uint32`` () =
    let i : sbyte = -1y
    Assert.AreEqual (UInt32.MaxValue, uint32 i)
  
  [<Fact>]
  member this.``int8.m1.To.uint32`` () =
    let i : int8 = -1y
    Assert.AreEqual (UInt32.MaxValue, uint32 i)
  
  [<Fact>]
  member this.``int16.m1.To.uint32`` () =
    let i : int16 = -1s
    Assert.AreEqual (UInt32.MaxValue, uint32 i)
  
  [<Fact>]
  member this.``int32.m1.To.uint32`` () =
    let i : int32 = -1l
    Assert.AreEqual (UInt32.MaxValue, uint32 i)
  
  [<Fact>]
  member this.``int64.m1.To.uint32`` () =
    let i : int64 = -1L
    Assert.AreEqual (UInt32.MaxValue, uint32 i)
  
  [<Fact>]
  member this.``sbyte.m1.To.uint64`` () =
    let i : sbyte = -1y
    Assert.AreEqual (UInt64.MaxValue, uint64 i)
  
  [<Fact>]
  member this.``int8.m1.To.uint64`` () =
    let i : int8 = -1y
    Assert.AreEqual (UInt64.MaxValue, uint64 i)
  
  [<Fact>]
  member this.``int16.m1.To.uint64`` () =
    let i : int16 = -1s
    Assert.AreEqual (UInt64.MaxValue, uint64 i)
  
  [<Fact>]
  member this.``int32.m1.To.uint64`` () =
    let i : int32 = -1l
    Assert.AreEqual (UInt64.MaxValue, uint64 i)
  
  [<Fact>]
  member this.``int64.m1.To.uint64`` () =
    let i : int64 = -1L
    Assert.AreEqual (UInt64.MaxValue, uint64 i)
  
  [<Fact>]
  member this.``sbyte.m1.To.sbyte`` () =
    let minus1 : sbyte = -1y
    let i : sbyte = -1y
    Assert.AreEqual (minus1, sbyte i)
  
  [<Fact>]
  member this.``int8.m1.To.sbyte`` () =
    let minus1 : sbyte = -1y
    let i : int8 = -1y
    Assert.AreEqual (minus1, sbyte i)
  
  [<Fact>]
  member this.``int16.m1.To.sbyte`` () =
    let minus1 : sbyte = -1y
    let i : int16 = -1s
    Assert.AreEqual (minus1, sbyte i)
  
  [<Fact>]
  member this.``int32.m1.To.sbyte`` () =
    let minus1 : sbyte = -1y
    let i : int32 = -1l
    Assert.AreEqual (minus1, sbyte i)
  
  [<Fact>]
  member this.``int64.m1.To.sbyte`` () =
    let minus1 : sbyte = -1y
    let i : int64 = -1L
    Assert.AreEqual (minus1, sbyte i)
  
  [<Fact>]
  member this.``sbyte.m1.To.int8`` () =
    let minus1 : int8 = -1y
    let i : sbyte = -1y
    Assert.AreEqual (minus1, int8 i)
  
  [<Fact>]
  member this.``int8.m1.To.int8`` () =
    let minus1 : int8 = -1y
    let i : int8 = -1y
    Assert.AreEqual (minus1, int8 i)
  
  [<Fact>]
  member this.``int16.m1.To.int8`` () =
    let minus1 : int8 = -1y
    let i : int16 = -1s
    Assert.AreEqual (minus1, int8 i)
  
  [<Fact>]
  member this.``int32.m1.To.int8`` () =
    let minus1 : int8 = -1y
    let i : int32 = -1l
    Assert.AreEqual (minus1, int8 i)
  
  [<Fact>]
  member this.``int64.m1.To.int8`` () =
    let minus1 : int8 = -1y
    let i : int64 = -1L
    Assert.AreEqual (minus1, int8 i)
  
  [<Fact>]
  member this.``sbyte.m1.To.int16`` () =
    let minus1 : int16 = -1s
    let i : sbyte = -1y
    Assert.AreEqual (minus1, int16 i)
  
  [<Fact>]
  member this.``int8.m1.To.int16`` () =
    let minus1 : int16 = -1s
    let i : int8 = -1y
    Assert.AreEqual (minus1, int16 i)
  
  [<Fact>]
  member this.``int16.m1.To.int16`` () =
    let minus1 : int16 = -1s
    let i : int16 = -1s
    Assert.AreEqual (minus1, int16 i)
  
  [<Fact>]
  member this.``int32.m1.To.int16`` () =
    let minus1 : int16 = -1s
    let i : int32 = -1l
    Assert.AreEqual (minus1, int16 i)
  
  [<Fact>]
  member this.``int64.m1.To.int16`` () =
    let minus1 : int16 = -1s
    let i : int64 = -1L
    Assert.AreEqual (minus1, int16 i)
  
  [<Fact>]
  member this.``sbyte.m1.To.int32`` () =
    let minus1 : int32 = -1l
    let i : sbyte = -1y
    Assert.AreEqual (minus1, int32 i)
  
  [<Fact>]
  member this.``int8.m1.To.int32`` () =
    let minus1 : int32 = -1l
    let i : int8 = -1y
    Assert.AreEqual (minus1, int32 i)
  
  [<Fact>]
  member this.``int16.m1.To.int32`` () =
    let minus1 : int32 = -1l
    let i : int16 = -1s
    Assert.AreEqual (minus1, int32 i)
  
  [<Fact>]
  member this.``int32.m1.To.int32`` () =
    let minus1 : int32 = -1l
    let i : int32 = -1l
    Assert.AreEqual (minus1, int32 i)
  
  [<Fact>]
  member this.``int64.m1.To.int32`` () =
    let minus1 : int32 = -1l
    let i : int64 = -1L
    Assert.AreEqual (minus1, int32 i)
  
  [<Fact>]
  member this.``sbyte.m1.To.int64`` () =
    let minus1 : int64 = -1L
    let i : sbyte = -1y
    Assert.AreEqual (minus1, int64 i)
  
  [<Fact>]
  member this.``int8.m1.To.int64`` () =
    let minus1 : int64 = -1L
    let i : int8 = -1y
    Assert.AreEqual (minus1, int64 i)
  
  [<Fact>]
  member this.``int16.m1.To.int64`` () =
    let minus1 : int64 = -1L
    let i : int16 = -1s
    Assert.AreEqual (minus1, int64 i)
  
  [<Fact>]
  member this.``int32.m1.To.int64`` () =
    let minus1 : int64 = -1L
    let i : int32 = -1l
    Assert.AreEqual (minus1, int64 i)
  
  [<Fact>]
  member this.``int64.m1.To.int64`` () =
    let minus1 : int64 = -1L
    let i : int64 = -1L
    Assert.AreEqual (minus1, int64 i)
  
  [<Fact>]
  member this.``byte.MaxValue.To.int16`` () =
    let sourceMaxValue : int16 = 0xFFs
    Assert.AreEqual (sourceMaxValue, int16 Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.int16`` () =
    let sourceMaxValue : int16 = 0xFFs
    Assert.AreEqual (sourceMaxValue, int16 UInt8.MaxValue)
  
  [<Fact>]
  member this.``byte.MaxValue.To.uint16`` () =
    let sourceMaxValue : uint16 = 0xFFus
    Assert.AreEqual (sourceMaxValue, uint16 Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.uint16`` () =
    let sourceMaxValue : uint16 = 0xFFus
    Assert.AreEqual (sourceMaxValue, uint16 UInt8.MaxValue)
  
  [<Fact>]
  member this.``byte.MaxValue.To.int32`` () =
    let sourceMaxValue : int32 = 0xFFl
    Assert.AreEqual (sourceMaxValue, int32 Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.int32`` () =
    let sourceMaxValue : int32 = 0xFFl
    Assert.AreEqual (sourceMaxValue, int32 UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.int32`` () =
    let sourceMaxValue : int32 = 0xFFFFl
    Assert.AreEqual (sourceMaxValue, int32 UInt16.MaxValue)
  
  [<Fact>]
  member this.``byte.MaxValue.To.uint32`` () =
    let sourceMaxValue : uint32 = 0xFFul
    Assert.AreEqual (sourceMaxValue, uint32 Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.uint32`` () =
    let sourceMaxValue : uint32 = 0xFFul
    Assert.AreEqual (sourceMaxValue, uint32 UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.uint32`` () =
    let sourceMaxValue : uint32 = 0xFFFFul
    Assert.AreEqual (sourceMaxValue, uint32 UInt16.MaxValue)
  
  [<Fact>]
  member this.``byte.MaxValue.To.int64`` () =
    let sourceMaxValue : int64 = 0xFFL
    Assert.AreEqual (sourceMaxValue, int64 Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.int64`` () =
    let sourceMaxValue : int64 = 0xFFL
    Assert.AreEqual (sourceMaxValue, int64 UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.int64`` () =
    let sourceMaxValue : int64 = 0xFFFFL
    Assert.AreEqual (sourceMaxValue, int64 UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.int64`` () =
    let sourceMaxValue : int64 = 0xFFFFFFFFL
    Assert.AreEqual (sourceMaxValue, int64 UInt32.MaxValue)
  
  [<Fact>]
  member this.``byte.MaxValue.To.uint64`` () =
    let sourceMaxValue : uint64 = 0xFFuL
    Assert.AreEqual (sourceMaxValue, uint64 Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.uint64`` () =
    let sourceMaxValue : uint64 = 0xFFuL
    Assert.AreEqual (sourceMaxValue, uint64 UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.uint64`` () =
    let sourceMaxValue : uint64 = 0xFFFFuL
    Assert.AreEqual (sourceMaxValue, uint64 UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.uint64`` () =
    let sourceMaxValue : uint64 = 0xFFFFFFFFuL
    Assert.AreEqual (sourceMaxValue, uint64 UInt32.MaxValue)
  
  [<Fact>]
  member this.``byte.MaxValue.To.sbyte`` () =
    Assert.AreEqual (-1y, sbyte Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.sbyte`` () =
    Assert.AreEqual (-1y, sbyte UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.sbyte`` () =
    Assert.AreEqual (-1y, sbyte UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.sbyte`` () =
    Assert.AreEqual (-1y, sbyte UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.sbyte`` () =
    Assert.AreEqual (-1y, sbyte UInt64.MaxValue)
  
  [<Fact>]
  member this.``byte.MaxValue.To.int8`` () =
    Assert.AreEqual (-1y, int8 Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.int8`` () =
    Assert.AreEqual (-1y, int8 UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.int8`` () =
    Assert.AreEqual (-1y, int8 UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.int8`` () =
    Assert.AreEqual (-1y, int8 UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.int8`` () =
    Assert.AreEqual (-1y, int8 UInt64.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.int16`` () =
    Assert.AreEqual (-1s, int16 UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.int16`` () =
    Assert.AreEqual (-1s, int16 UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.int16`` () =
    Assert.AreEqual (-1s, int16 UInt64.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.int32`` () =
    Assert.AreEqual (-1l, int32 UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.int32`` () =
    Assert.AreEqual (-1l, int32 UInt64.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.int64`` () =
    Assert.AreEqual (-1L, int64 UInt64.MaxValue)
  
  [<Fact>]
  member this.``byte.MaxValue.To.byte`` () =
    Assert.AreEqual (Byte.MaxValue, byte Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.byte`` () =
    Assert.AreEqual (Byte.MaxValue, byte UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.byte`` () =
    Assert.AreEqual (Byte.MaxValue, byte UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.byte`` () =
    Assert.AreEqual (Byte.MaxValue, byte UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.byte`` () =
    Assert.AreEqual (Byte.MaxValue, byte UInt64.MaxValue)
  
  [<Fact>]
  member this.``byte.MaxValue.To.uint8`` () =
    Assert.AreEqual (UInt8.MaxValue, uint8 Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.uint8`` () =
    Assert.AreEqual (UInt8.MaxValue, uint8 UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.uint8`` () =
    Assert.AreEqual (UInt8.MaxValue, uint8 UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.uint8`` () =
    Assert.AreEqual (UInt8.MaxValue, uint8 UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.uint8`` () =
    Assert.AreEqual (UInt8.MaxValue, uint8 UInt64.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.uint16`` () =
    Assert.AreEqual (UInt16.MaxValue, uint16 UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.uint16`` () =
    Assert.AreEqual (UInt16.MaxValue, uint16 UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.uint16`` () =
    Assert.AreEqual (UInt16.MaxValue, uint16 UInt64.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.uint32`` () =
    Assert.AreEqual (UInt32.MaxValue, uint32 UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.uint32`` () =
    Assert.AreEqual (UInt32.MaxValue, uint32 UInt64.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.uint64`` () =
    Assert.AreEqual (UInt64.MaxValue, uint64 UInt64.MaxValue)
  
  [<Fact>]
  member this.``sbyte.m1.To.nativeint`` () =
    Assert.AreEqual (-1n, nativeint -1y)
  
  [<Fact>]
  member this.``int8.m1.To.nativeint`` () =
    Assert.AreEqual (-1n, nativeint -1y)
  
  [<Fact>]
  member this.``int16.m1.To.nativeint`` () =
    Assert.AreEqual (-1n, nativeint -1s)
  
  [<Fact>]
  member this.``int32.m1.To.nativeint`` () =
    Assert.AreEqual (-1n, nativeint -1l)
  
  [<Fact>]
  member this.``int64.m1.To.nativeint`` () =
    Assert.AreEqual (-1n, nativeint -1L)
  
  [<Fact>]
  member this.``byte.MaxValue.To.nativeint`` () =
    if sizeof<nativeint> > sizeof<byte> then
       let sourceMaxValue : nativeint = 0xFFn
       Assert.AreEqual (sourceMaxValue, nativeint Byte.MaxValue)
    else
       Assert.AreEqual (-1n, nativeint Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.MaxValue.To.nativeint`` () =
    if sizeof<nativeint> > sizeof<uint8> then
       let sourceMaxValue : nativeint = 0xFFn
       Assert.AreEqual (sourceMaxValue, nativeint UInt8.MaxValue)
    else
       Assert.AreEqual (-1n, nativeint UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.MaxValue.To.nativeint`` () =
    if sizeof<nativeint> > sizeof<uint16> then
       let sourceMaxValue : nativeint = 0xFFFFn
       Assert.AreEqual (sourceMaxValue, nativeint UInt16.MaxValue)
    else
       Assert.AreEqual (-1n, nativeint UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.MaxValue.To.nativeint`` () =
    if sizeof<nativeint> > sizeof<uint32> then
       let sourceMaxValue : nativeint = 0xFFFFFFFFn
       Assert.AreEqual (sourceMaxValue, nativeint UInt32.MaxValue)
    else
       Assert.AreEqual (-1n, nativeint UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.MaxValue.To.nativeint`` () =
    if sizeof<nativeint> > sizeof<uint64> then
       let sourceMaxValue : nativeint = 0xFFFFFFFFFFFFFFFFn
       Assert.AreEqual (sourceMaxValue, nativeint UInt64.MaxValue)
    else
       Assert.AreEqual (-1n, nativeint UInt64.MaxValue)
  
  member private this.UnativeintMaxValue =
    let mutable unativeintMaxValue : unativeint = 0un
    for i = 1 to sizeof<nativeint> do
       unativeintMaxValue <- (unativeintMaxValue <<< 8) ||| 0xFFun
    unativeintMaxValue
  
  [<Fact>]
  member this.``sbyte.m1.To.unativeint`` () =
    Assert.AreEqual (this.UnativeintMaxValue, unativeint -1y)
  
  [<Fact>]
  member this.``int8.m1.To.unativeint`` () =
    Assert.AreEqual (this.UnativeintMaxValue, unativeint -1y)
  
  [<Fact>]
  member this.``int16.m1.To.unativeint`` () =
    Assert.AreEqual (this.UnativeintMaxValue, unativeint -1s)
  
  [<Fact>]
  member this.``int32.m1.To.unativeint`` () =
    Assert.AreEqual (this.UnativeintMaxValue, unativeint -1l)
  
  [<Fact>]
  member this.``int64.m1.To.unativeint`` () =
    Assert.AreEqual (this.UnativeintMaxValue, unativeint -1L)
  
  [<Fact>]
  member this.``byte.m1.To.unativeint`` () =
    if sizeof<unativeint> > sizeof<byte> then
       let sourceMaxValue : unativeint = 0xFFun
       Assert.AreEqual (sourceMaxValue, unativeint Byte.MaxValue)
    else
       Assert.AreEqual (this.UnativeintMaxValue, unativeint Byte.MaxValue)
  
  [<Fact>]
  member this.``uint8.m1.To.unativeint`` () =
    if sizeof<unativeint> > sizeof<uint8> then
       let sourceMaxValue : unativeint = 0xFFun
       Assert.AreEqual (sourceMaxValue, unativeint UInt8.MaxValue)
    else
       Assert.AreEqual (this.UnativeintMaxValue, unativeint UInt8.MaxValue)
  
  [<Fact>]
  member this.``uint16.m1.To.unativeint`` () =
    if sizeof<unativeint> > sizeof<uint16> then
       let sourceMaxValue : unativeint = 0xFFFFun
       Assert.AreEqual (sourceMaxValue, unativeint UInt16.MaxValue)
    else
       Assert.AreEqual (this.UnativeintMaxValue, unativeint UInt16.MaxValue)
  
  [<Fact>]
  member this.``uint32.m1.To.unativeint`` () =
    if sizeof<unativeint> > sizeof<uint32> then
       let sourceMaxValue : unativeint = 0xFFFFFFFFun
       Assert.AreEqual (sourceMaxValue, unativeint UInt32.MaxValue)
    else
       Assert.AreEqual (this.UnativeintMaxValue, unativeint UInt32.MaxValue)
  
  [<Fact>]
  member this.``uint64.m1.To.unativeint`` () =
    if sizeof<unativeint> > sizeof<uint64> then
       let sourceMaxValue : unativeint = 0xFFFFFFFFFFFFFFFFun
       Assert.AreEqual (sourceMaxValue, unativeint UInt64.MaxValue)
    else
       Assert.AreEqual (this.UnativeintMaxValue, unativeint UInt64.MaxValue)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.byte`` () =
    let i : sbyte = -1y
    CheckThrowsExn<OverflowException>(fun () -> Checked.byte i |> ignore)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.byte`` () =
    let i : int16 = -1s
    CheckThrowsExn<OverflowException>(fun () -> Checked.byte i |> ignore)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.byte`` () =
    let i : int32 = -1l
    CheckThrowsExn<OverflowException>(fun () -> Checked.byte i |> ignore)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.byte`` () =
    let i : int64 = -1L
    CheckThrowsExn<OverflowException>(fun () -> Checked.byte i |> ignore)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.uint16`` () =
    let i : sbyte = -1y
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint16 i |> ignore)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.uint16`` () =
    let i : int16 = -1s
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint16 i |> ignore)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.uint16`` () =
    let i : int32 = -1l
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint16 i |> ignore)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.uint16`` () =
    let i : int64 = -1L
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint16 i |> ignore)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.uint32`` () =
    let i : sbyte = -1y
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint32 i |> ignore)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.uint32`` () =
    let i : int16 = -1s
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint32 i |> ignore)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.uint32`` () =
    let i : int32 = -1l
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint32 i |> ignore)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.uint32`` () =
    let i : int64 = -1L
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint32 i |> ignore)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.uint64`` () =
    let i : sbyte = -1y
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint64 i |> ignore)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.uint64`` () =
    let i : int16 = -1s
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint64 i |> ignore)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.uint64`` () =
    let i : int32 = -1l
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint64 i |> ignore)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.uint64`` () =
    let i : int64 = -1L
    CheckThrowsExn<OverflowException>(fun () -> Checked.uint64 i |> ignore)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.sbyte`` () =
    let minus1 : sbyte = -1y
    let i : sbyte = -1y
    Assert.AreEqual (minus1, Checked.sbyte i)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.sbyte`` () =
    let minus1 : sbyte = -1y
    let i : int16 = -1s
    Assert.AreEqual (minus1, Checked.sbyte i)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.sbyte`` () =
    let minus1 : sbyte = -1y
    let i : int32 = -1l
    Assert.AreEqual (minus1, Checked.sbyte i)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.sbyte`` () =
    let minus1 : sbyte = -1y
    let i : int64 = -1L
    Assert.AreEqual (minus1, Checked.sbyte i)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.int16`` () =
    let minus1 : int16 = -1s
    let i : sbyte = -1y
    Assert.AreEqual (minus1, Checked.int16 i)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.int16`` () =
    let minus1 : int16 = -1s
    let i : int16 = -1s
    Assert.AreEqual (minus1, Checked.int16 i)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.int16`` () =
    let minus1 : int16 = -1s
    let i : int32 = -1l
    Assert.AreEqual (minus1, Checked.int16 i)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.int16`` () =
    let minus1 : int16 = -1s
    let i : int64 = -1L
    Assert.AreEqual (minus1, Checked.int16 i)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.int32`` () =
    let minus1 : int32 = -1l
    let i : sbyte = -1y
    Assert.AreEqual (minus1, Checked.int32 i)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.int32`` () =
    let minus1 : int32 = -1l
    let i : int16 = -1s
    Assert.AreEqual (minus1, Checked.int32 i)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.int32`` () =
    let minus1 : int32 = -1l
    let i : int32 = -1l
    Assert.AreEqual (minus1, Checked.int32 i)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.int32`` () =
    let minus1 : int32 = -1l
    let i : int64 = -1L
    Assert.AreEqual (minus1, Checked.int32 i)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.int64`` () =
    let minus1 : int64 = -1L
    let i : sbyte = -1y
    Assert.AreEqual (minus1, Checked.int64 i)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.int64`` () =
    let minus1 : int64 = -1L
    let i : int16 = -1s
    Assert.AreEqual (minus1, Checked.int64 i)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.int64`` () =
    let minus1 : int64 = -1L
    let i : int32 = -1l
    Assert.AreEqual (minus1, Checked.int64 i)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.int64`` () =
    let minus1 : int64 = -1L
    let i : int64 = -1L
    Assert.AreEqual (minus1, Checked.int64 i)
  
  [<Fact>]
  member this.``Checked.byte.MaxValue.To.int16`` () =
    let sourceMaxValue : int16 = 0xFFs
    Assert.AreEqual (sourceMaxValue, Checked.int16 Byte.MaxValue)
  
  [<Fact>]
  member this.``Checked.byte.MaxValue.To.uint16`` () =
    let sourceMaxValue : uint16 = 0xFFus
    Assert.AreEqual (sourceMaxValue, Checked.uint16 Byte.MaxValue)
  
  [<Fact>]
  member this.``Checked.byte.MaxValue.To.int32`` () =
    let sourceMaxValue : int32 = 0xFFl
    Assert.AreEqual (sourceMaxValue, Checked.int32 Byte.MaxValue)
  
  [<Fact>]
  member this.``Checked.uint16.MaxValue.To.int32`` () =
    let sourceMaxValue : int32 = 0xFFFFl
    Assert.AreEqual (sourceMaxValue, Checked.int32 UInt16.MaxValue)
  
  [<Fact>]
  member this.``Checked.byte.MaxValue.To.uint32`` () =
    let sourceMaxValue : uint32 = 0xFFul
    Assert.AreEqual (sourceMaxValue, Checked.uint32 Byte.MaxValue)
  
  [<Fact>]
  member this.``Checked.uint16.MaxValue.To.uint32`` () =
    let sourceMaxValue : uint32 = 0xFFFFul
    Assert.AreEqual (sourceMaxValue, Checked.uint32 UInt16.MaxValue)
  
  [<Fact>]
  member this.``Checked.byte.MaxValue.To.int64`` () =
    let sourceMaxValue : int64 = 0xFFL
    Assert.AreEqual (sourceMaxValue, Checked.int64 Byte.MaxValue)
  
  [<Fact>]
  member this.``Checked.uint16.MaxValue.To.int64`` () =
    let sourceMaxValue : int64 = 0xFFFFL
    Assert.AreEqual (sourceMaxValue, Checked.int64 UInt16.MaxValue)
  
  [<Fact>]
  member this.``Checked.uint32.MaxValue.To.int64`` () =
    let sourceMaxValue : int64 = 0xFFFFFFFFL
    Assert.AreEqual (sourceMaxValue, Checked.int64 UInt32.MaxValue)
  
  [<Fact>]
  member this.``Checked.byte.MaxValue.To.uint64`` () =
    let sourceMaxValue : uint64 = 0xFFuL
    Assert.AreEqual (sourceMaxValue, Checked.uint64 Byte.MaxValue)
  
  [<Fact>]
  member this.``Checked.uint16.MaxValue.To.uint64`` () =
    let sourceMaxValue : uint64 = 0xFFFFuL
    Assert.AreEqual (sourceMaxValue, Checked.uint64 UInt16.MaxValue)
  
  [<Fact>]
  member this.``Checked.uint32.MaxValue.To.uint64`` () =
    let sourceMaxValue : uint64 = 0xFFFFFFFFuL
    Assert.AreEqual (sourceMaxValue, Checked.uint64 UInt32.MaxValue)
  
  [<Fact>]
  member this.``Checked.byte.MaxValue.To.sbyte`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.sbyte Byte.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint16.MaxValue.To.sbyte`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.sbyte UInt16.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint32.MaxValue.To.sbyte`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.sbyte UInt32.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint64.MaxValue.To.sbyte`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.sbyte UInt64.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint16.MaxValue.To.int16`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.int16 UInt16.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint32.MaxValue.To.int16`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.int16 UInt32.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint64.MaxValue.To.int16`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.int16 UInt64.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint32.MaxValue.To.int32`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.int32 UInt32.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint64.MaxValue.To.int32`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.int32 UInt64.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint64.MaxValue.To.int64`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.int64 UInt64.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint16.MaxValue.To.byte`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.byte UInt16.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint32.MaxValue.To.byte`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.byte UInt32.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint64.MaxValue.To.byte`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.byte UInt64.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint32.MaxValue.To.uint16`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.uint16 UInt32.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint64.MaxValue.To.uint16`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.uint16 UInt64.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint64.MaxValue.To.uint32`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.uint32 UInt64.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.nativeint`` () =
    Assert.AreEqual (-1n, Checked.nativeint -1y)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.nativeint`` () =
    Assert.AreEqual (-1n, Checked.nativeint -1s)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.nativeint`` () =
    Assert.AreEqual (-1n, Checked.nativeint -1l)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.nativeint`` () =
    Assert.AreEqual (-1n, Checked.nativeint -1L)
  
  [<Fact>]
  member this.``Checked.byte.MaxValue.To.nativeint`` () =
    if sizeof<nativeint> > sizeof<byte> then
       let sourceMaxValue : nativeint = 0xFFn
       Assert.AreEqual (sourceMaxValue, Checked.nativeint Byte.MaxValue)
    else
       CheckThrowsExn<OverflowException> (fun () -> Checked.nativeint Byte.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint16.MaxValue.To.nativeint`` () =
    if sizeof<nativeint> > sizeof<uint16> then
       let sourceMaxValue : nativeint = 0xFFFFn
       Assert.AreEqual (sourceMaxValue, Checked.nativeint UInt16.MaxValue)
    else
       CheckThrowsExn<OverflowException> (fun () -> Checked.nativeint UInt16.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint32.MaxValue.To.nativeint`` () =
    if sizeof<nativeint> > sizeof<uint32> then
       let sourceMaxValue : nativeint = 0xFFFFFFFFn
       Assert.AreEqual (sourceMaxValue, Checked.nativeint UInt32.MaxValue)
    else
       CheckThrowsExn<OverflowException> (fun () -> Checked.nativeint UInt32.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint64.MaxValue.To.nativeint`` () =
    if sizeof<nativeint> > sizeof<uint64> then
       let sourceMaxValue : nativeint = 0xFFFFFFFFFFFFFFFFn
       Assert.AreEqual (sourceMaxValue, Checked.nativeint UInt64.MaxValue)
    else
       CheckThrowsExn<OverflowException> (fun () -> Checked.nativeint UInt64.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.sbyte.m1.To.unativeint`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.unativeint -1y |> ignore)
  
  [<Fact>]
  member this.``Checked.int16.m1.To.unativeint`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.unativeint -1s |> ignore)
  
  [<Fact>]
  member this.``Checked.int32.m1.To.unativeint`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.unativeint -1l |> ignore)
  
  [<Fact>]
  member this.``Checked.int64.m1.To.unativeint`` () =
    CheckThrowsExn<OverflowException> (fun () -> Checked.unativeint -1L |> ignore)
  
  [<Fact>]
  member this.``Checked.byte.MaxValue.To.unativeint`` () =
    if sizeof<unativeint> >= sizeof<byte> then
       let sourceMaxValue : unativeint = 0xFFun
       Assert.AreEqual (sourceMaxValue, Checked.unativeint Byte.MaxValue)
    else
       CheckThrowsExn<OverflowException> (fun () -> Checked.unativeint Byte.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint16.MaxValue.To.unativeint`` () =
    if sizeof<unativeint> >= sizeof<uint16> then
       let sourceMaxValue : unativeint = 0xFFFFun
       Assert.AreEqual (sourceMaxValue, Checked.unativeint UInt16.MaxValue)
    else
       CheckThrowsExn<OverflowException> (fun () -> Checked.unativeint UInt16.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint32.MaxValue.To.unativeint`` () =
    if sizeof<unativeint> >= sizeof<uint32> then
       let sourceMaxValue : unativeint = 0xFFFFFFFFun
       Assert.AreEqual (sourceMaxValue, Checked.unativeint UInt32.MaxValue)
    else
       CheckThrowsExn<OverflowException> (fun () -> Checked.unativeint UInt32.MaxValue |> ignore)
  
  [<Fact>]
  member this.``Checked.uint64.MaxValue.To.unativeint`` () =
    if sizeof<unativeint> >= sizeof<uint64> then
       let sourceMaxValue : unativeint = 0xFFFFFFFFFFFFFFFFun
       Assert.AreEqual (sourceMaxValue, Checked.unativeint UInt64.MaxValue)
    else
       CheckThrowsExn<OverflowException> (fun () -> Checked.unativeint UInt64.MaxValue |> ignore)
  