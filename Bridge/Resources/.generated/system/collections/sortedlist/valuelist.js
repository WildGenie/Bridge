    /*System.Collections.SortedList+ValueList start.*/
    Bridge.define("System.Collections.SortedList.ValueList", {
        inherits: [System.Collections.IList],
        $kind: "nested class",
        fields: {
            sortedList: null
        },
        props: {
            Count: {
                get: function () {
                    return this.sortedList._size;
                }
            },
            IsReadOnly: {
                get: function () {
                    return true;
                }
            },
            IsFixedSize: {
                get: function () {
                    return true;
                }
            },
            IsSynchronized: {
                get: function () {
                    return this.sortedList.IsSynchronized;
                }
            },
            SyncRoot: {
                get: function () {
                    return this.sortedList.SyncRoot;
                }
            }
        },
        alias: [
            "Count", "System$Collections$ICollection$Count",
            "IsReadOnly", "System$Collections$IList$IsReadOnly",
            "IsFixedSize", "System$Collections$IList$IsFixedSize",
            "IsSynchronized", "System$Collections$ICollection$IsSynchronized",
            "SyncRoot", "System$Collections$ICollection$SyncRoot",
            "add", "System$Collections$IList$add",
            "clear", "System$Collections$IList$clear",
            "contains", "System$Collections$IList$contains",
            "copyTo", "System$Collections$ICollection$copyTo",
            "insert", "System$Collections$IList$insert",
            "getItem", "System$Collections$IList$getItem",
            "setItem", "System$Collections$IList$setItem",
            "GetEnumerator", "System$Collections$IEnumerable$GetEnumerator",
            "indexOf", "System$Collections$IList$indexOf",
            "remove", "System$Collections$IList$remove",
            "removeAt", "System$Collections$IList$removeAt"
        ],
        ctors: {
            ctor: function (sortedList) {
                this.$initialize();
                this.sortedList = sortedList;
            }
        },
        methods: {
            getItem: function (index) {
                return this.sortedList.GetByIndex(index);
            },
            setItem: function (index, value) {
                throw new System.NotSupportedException.ctor();
            },
            /*System.Collections.SortedList+ValueList.add start.*/
            add: function (key) {
                throw new System.NotSupportedException.ctor();
            },
            /*System.Collections.SortedList+ValueList.add end.*/

            /*System.Collections.SortedList+ValueList.clear start.*/
            clear: function () {
                throw new System.NotSupportedException.ctor();
            },
            /*System.Collections.SortedList+ValueList.clear end.*/

            /*System.Collections.SortedList+ValueList.contains start.*/
            contains: function (value) {
                return this.sortedList.ContainsValue(value);
            },
            /*System.Collections.SortedList+ValueList.contains end.*/

            /*System.Collections.SortedList+ValueList.copyTo start.*/
            copyTo: function (array, arrayIndex) {
                if (array != null && System.Array.getRank(array) !== 1) {
                    throw new System.ArgumentException.ctor();
                }

                System.Array.copy(this.sortedList.values, 0, array, arrayIndex, this.sortedList.Count);
            },
            /*System.Collections.SortedList+ValueList.copyTo end.*/

            /*System.Collections.SortedList+ValueList.insert start.*/
            insert: function (index, value) {
                throw new System.NotSupportedException.ctor();
            },
            /*System.Collections.SortedList+ValueList.insert end.*/

            /*System.Collections.SortedList+ValueList.GetEnumerator start.*/
            GetEnumerator: function () {
                return new System.Collections.SortedList.SortedListEnumerator(this.sortedList, 0, this.sortedList.Count, System.Collections.SortedList.SortedListEnumerator.Values);
            },
            /*System.Collections.SortedList+ValueList.GetEnumerator end.*/

            /*System.Collections.SortedList+ValueList.indexOf start.*/
            indexOf: function (value) {
                return System.Array.indexOfT(this.sortedList.values, value, 0, this.sortedList.Count);
            },
            /*System.Collections.SortedList+ValueList.indexOf end.*/

            /*System.Collections.SortedList+ValueList.remove start.*/
            remove: function (value) {
                throw new System.NotSupportedException.ctor();
            },
            /*System.Collections.SortedList+ValueList.remove end.*/

            /*System.Collections.SortedList+ValueList.removeAt start.*/
            removeAt: function (index) {
                throw new System.NotSupportedException.ctor();
            },
            /*System.Collections.SortedList+ValueList.removeAt end.*/


        },
        overloads: {
            "Add(Object)": "add",
            "Clear()": "clear",
            "Contains(Object)": "contains",
            "CopyTo(Array, int)": "copyTo",
            "Insert(int, Object)": "insert",
            "IndexOf(Object)": "indexOf",
            "Remove(Object)": "remove",
            "RemoveAt(int)": "removeAt"
        }
    });
    /*System.Collections.SortedList+ValueList end.*/