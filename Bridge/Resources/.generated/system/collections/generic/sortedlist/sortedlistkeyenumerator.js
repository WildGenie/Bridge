    /*System.Collections.Generic.SortedList$2+SortedListKeyEnumerator start.*/
    Bridge.define("System.Collections.Generic.SortedList$2.SortedListKeyEnumerator", function (TKey, TValue) { return {
        inherits: [System.Collections.Generic.IEnumerator$1(TKey),System.Collections.IEnumerator],
        $kind: "nested class",
        fields: {
            _sortedList: null,
            index: 0,
            version: 0,
            currentKey: Bridge.getDefaultValue(TKey)
        },
        props: {
            Current: {
                get: function () {
                    return this.currentKey;
                }
            },
            System$Collections$IEnumerator$Current: {
                get: function () {
                    if (this.index === 0 || (this.index === ((this._sortedList.Count + 1) | 0))) {
                        System.ThrowHelper.ThrowInvalidOperationException(System.ExceptionResource.InvalidOperation_EnumOpCantHappen);
                    }

                    return this.currentKey;
                }
            }
        },
        alias: [
            "Dispose", "System$IDisposable$Dispose",
            "moveNext", "System$Collections$IEnumerator$moveNext",
            "Current", ["System$Collections$Generic$IEnumerator$1$" + Bridge.getTypeAlias(TKey) + "$Current$1", "System$Collections$Generic$IEnumerator$1$Current$1"]
        ],
        ctors: {
            init: function () {
                this.currentKey = Bridge.getDefaultValue(TKey);
            },
            ctor: function (sortedList) {
                this.$initialize();
                this._sortedList = sortedList;
                this.version = sortedList.version;
            }
        },
        methods: {
            /*System.Collections.Generic.SortedList$2+SortedListKeyEnumerator.Dispose start.*/
            Dispose: function () {
                this.index = 0;
                this.currentKey = Bridge.getDefaultValue(TKey);
            },
            /*System.Collections.Generic.SortedList$2+SortedListKeyEnumerator.Dispose end.*/

            /*System.Collections.Generic.SortedList$2+SortedListKeyEnumerator.moveNext start.*/
            moveNext: function () {
                var $t;
                if (this.version !== this._sortedList.version) {
                    System.ThrowHelper.ThrowInvalidOperationException(System.ExceptionResource.InvalidOperation_EnumFailedVersion);
                }

                if ((this.index >>> 0) < ((this._sortedList.Count) >>> 0)) {
                    this.currentKey = ($t = this._sortedList.keys)[System.Array.index(this.index, $t)];
                    this.index = (this.index + 1) | 0;
                    return true;
                }

                this.index = (this._sortedList.Count + 1) | 0;
                this.currentKey = Bridge.getDefaultValue(TKey);
                return false;
            },
            /*System.Collections.Generic.SortedList$2+SortedListKeyEnumerator.moveNext end.*/

            /*System.Collections.Generic.SortedList$2+SortedListKeyEnumerator.System$Collections$IEnumerator$reset start.*/
            System$Collections$IEnumerator$reset: function () {
                if (this.version !== this._sortedList.version) {
                    System.ThrowHelper.ThrowInvalidOperationException(System.ExceptionResource.InvalidOperation_EnumFailedVersion);
                }
                this.index = 0;
                this.currentKey = Bridge.getDefaultValue(TKey);
            },
            /*System.Collections.Generic.SortedList$2+SortedListKeyEnumerator.System$Collections$IEnumerator$reset end.*/


        },
        overloads: {
            "MoveNext()": "moveNext"
        }
    }; });
    /*System.Collections.Generic.SortedList$2+SortedListKeyEnumerator end.*/