    /*System.IO.Stream start.*/
    Bridge.define("System.IO.Stream", {
        inherits: [System.IDisposable],
        statics: {
            fields: {
                _DefaultCopyBufferSize: 0,
                Null: null
            },
            ctors: {
                init: function () {
                    this._DefaultCopyBufferSize = 81920;
                    this.Null = new System.IO.Stream.NullStream();
                }
            },
            methods: {
                /*System.IO.Stream.Synchronized:static start.*/
                Synchronized: function (stream) {
                    if (stream == null) {
                        throw new System.ArgumentNullException.$ctor1("stream");
                    }

                    return stream;
                },
                /*System.IO.Stream.Synchronized:static end.*/

                /*System.IO.Stream.BlockingEndRead:static start.*/
                BlockingEndRead: function (asyncResult) {

                    return System.IO.Stream.SynchronousAsyncResult.EndRead(asyncResult);
                },
                /*System.IO.Stream.BlockingEndRead:static end.*/

                /*System.IO.Stream.BlockingEndWrite:static start.*/
                BlockingEndWrite: function (asyncResult) {
                    System.IO.Stream.SynchronousAsyncResult.EndWrite(asyncResult);
                },
                /*System.IO.Stream.BlockingEndWrite:static end.*/


            }
        },
        props: {
            CanTimeout: {
                get: function () {
                    return false;
                }
            },
            ReadTimeout: {
                get: function () {
                    throw new System.InvalidOperationException.ctor();
                },
                set: function (value) {
                    throw new System.InvalidOperationException.ctor();
                }
            },
            WriteTimeout: {
                get: function () {
                    throw new System.InvalidOperationException.ctor();
                },
                set: function (value) {
                    throw new System.InvalidOperationException.ctor();
                }
            }
        },
        alias: ["Dispose", "System$IDisposable$Dispose"],
        methods: {
            /*System.IO.Stream.CopyTo start.*/
            CopyTo: function (destination) {
                if (destination == null) {
                    throw new System.ArgumentNullException.$ctor1("destination");
                }
                if (!this.CanRead && !this.CanWrite) {
                    throw new System.Exception();
                }
                if (!destination.CanRead && !destination.CanWrite) {
                    throw new System.Exception("destination");
                }
                if (!this.CanRead) {
                    throw new System.NotSupportedException.ctor();
                }
                if (!destination.CanWrite) {
                    throw new System.NotSupportedException.ctor();
                }

                this.InternalCopyTo(destination, System.IO.Stream._DefaultCopyBufferSize);
            },
            /*System.IO.Stream.CopyTo end.*/

            /*System.IO.Stream.CopyTo$1 start.*/
            CopyTo$1: function (destination, bufferSize) {
                if (destination == null) {
                    throw new System.ArgumentNullException.$ctor1("destination");
                }
                if (bufferSize <= 0) {
                    throw new System.ArgumentOutOfRangeException.$ctor1("bufferSize");
                }
                if (!this.CanRead && !this.CanWrite) {
                    throw new System.Exception();
                }
                if (!destination.CanRead && !destination.CanWrite) {
                    throw new System.Exception("destination");
                }
                if (!this.CanRead) {
                    throw new System.NotSupportedException.ctor();
                }
                if (!destination.CanWrite) {
                    throw new System.NotSupportedException.ctor();
                }

                this.InternalCopyTo(destination, bufferSize);
            },
            /*System.IO.Stream.CopyTo$1 end.*/

            /*System.IO.Stream.InternalCopyTo start.*/
            InternalCopyTo: function (destination, bufferSize) {

                var buffer = System.Array.init(bufferSize, 0, System.Byte);
                var read;
                while (((read = this.Read(buffer, 0, buffer.length))) !== 0) {
                    destination.Write(buffer, 0, read);
                }
            },
            /*System.IO.Stream.InternalCopyTo end.*/

            /*System.IO.Stream.Close start.*/
            Close: function () {
                /* These are correct, but we'd have to fix PipeStream & NetworkStream very carefully.
                Contract.Ensures(CanRead == false);
                Contract.Ensures(CanWrite == false);
                Contract.Ensures(CanSeek == false);
                */

                this.Dispose$1(true);
            },
            /*System.IO.Stream.Close end.*/

            /*System.IO.Stream.Dispose start.*/
            Dispose: function () {
                /* These are correct, but we'd have to fix PipeStream & NetworkStream very carefully.
                Contract.Ensures(CanRead == false);
                Contract.Ensures(CanWrite == false);
                Contract.Ensures(CanSeek == false);
                */

                this.Close();
            },
            /*System.IO.Stream.Dispose end.*/

            /*System.IO.Stream.Dispose$1 start.*/
            Dispose$1: function (disposing) { },
            /*System.IO.Stream.Dispose$1 end.*/

            /*System.IO.Stream.BeginRead start.*/
            BeginRead: function (buffer, offset, count, callback, state) {
                return this.BeginReadInternal(buffer, offset, count, callback, state, false);
            },
            /*System.IO.Stream.BeginRead end.*/

            /*System.IO.Stream.BeginReadInternal start.*/
            BeginReadInternal: function (buffer, offset, count, callback, state, serializeAsynchronously) {
                if (!this.CanRead) {
                    System.IO.__Error.ReadNotSupported();
                }

                return this.BlockingBeginRead(buffer, offset, count, callback, state);
            },
            /*System.IO.Stream.BeginReadInternal end.*/

            /*System.IO.Stream.EndRead start.*/
            EndRead: function (asyncResult) {
                if (asyncResult == null) {
                    throw new System.ArgumentNullException.$ctor1("asyncResult");
                }

                return System.IO.Stream.BlockingEndRead(asyncResult);
            },
            /*System.IO.Stream.EndRead end.*/

            /*System.IO.Stream.BeginWrite start.*/
            BeginWrite: function (buffer, offset, count, callback, state) {
                return this.BeginWriteInternal(buffer, offset, count, callback, state, false);
            },
            /*System.IO.Stream.BeginWrite end.*/

            /*System.IO.Stream.BeginWriteInternal start.*/
            BeginWriteInternal: function (buffer, offset, count, callback, state, serializeAsynchronously) {
                if (!this.CanWrite) {
                    System.IO.__Error.WriteNotSupported();
                }
                return this.BlockingBeginWrite(buffer, offset, count, callback, state);
            },
            /*System.IO.Stream.BeginWriteInternal end.*/

            /*System.IO.Stream.EndWrite start.*/
            EndWrite: function (asyncResult) {
                if (asyncResult == null) {
                    throw new System.ArgumentNullException.$ctor1("asyncResult");
                }

                System.IO.Stream.BlockingEndWrite(asyncResult);
            },
            /*System.IO.Stream.EndWrite end.*/

            /*System.IO.Stream.ReadByte start.*/
            ReadByte: function () {

                var oneByteArray = System.Array.init(1, 0, System.Byte);
                var r = this.Read(oneByteArray, 0, 1);
                if (r === 0) {
                    return -1;
                }
                return oneByteArray[System.Array.index(0, oneByteArray)];
            },
            /*System.IO.Stream.ReadByte end.*/

            /*System.IO.Stream.WriteByte start.*/
            WriteByte: function (value) {
                var oneByteArray = System.Array.init(1, 0, System.Byte);
                oneByteArray[System.Array.index(0, oneByteArray)] = value;
                this.Write(oneByteArray, 0, 1);
            },
            /*System.IO.Stream.WriteByte end.*/

            /*System.IO.Stream.BlockingBeginRead start.*/
            BlockingBeginRead: function (buffer, offset, count, callback, state) {

                var asyncResult;
                try {
                    var numRead = this.Read(buffer, offset, count);
                    asyncResult = new System.IO.Stream.SynchronousAsyncResult.$ctor1(numRead, state);
                } catch ($e1) {
                    $e1 = System.Exception.create($e1);
                    var ex;
                    if (Bridge.is($e1, System.IO.IOException)) {
                        ex = $e1;
                        asyncResult = new System.IO.Stream.SynchronousAsyncResult.ctor(ex, state, false);
                    } else {
                        throw $e1;
                    }
                }

                if (!Bridge.staticEquals(callback, null)) {
                    callback(asyncResult);
                }

                return asyncResult;
            },
            /*System.IO.Stream.BlockingBeginRead end.*/

            /*System.IO.Stream.BlockingBeginWrite start.*/
            BlockingBeginWrite: function (buffer, offset, count, callback, state) {

                var asyncResult;
                try {
                    this.Write(buffer, offset, count);
                    asyncResult = new System.IO.Stream.SynchronousAsyncResult.$ctor2(state);
                } catch ($e1) {
                    $e1 = System.Exception.create($e1);
                    var ex;
                    if (Bridge.is($e1, System.IO.IOException)) {
                        ex = $e1;
                        asyncResult = new System.IO.Stream.SynchronousAsyncResult.ctor(ex, state, true);
                    } else {
                        throw $e1;
                    }
                }

                if (!Bridge.staticEquals(callback, null)) {
                    callback(asyncResult);
                }

                return asyncResult;
            },
            /*System.IO.Stream.BlockingBeginWrite end.*/


        },
        overloads: {
            "CopyTo(Stream, int)": "CopyTo$1",
            "Dispose(bool)": "Dispose$1"
        }
    });
    /*System.IO.Stream end.*/