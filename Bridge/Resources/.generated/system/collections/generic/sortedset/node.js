    /*System.Collections.Generic.SortedSet$1+Node start.*/
    Bridge.define("System.Collections.Generic.SortedSet$1.Node", function (T) { return {
        $kind: "nested class",
        fields: {
            IsRed: false,
            Item: Bridge.getDefaultValue(T),
            Left: null,
            Right: null
        },
        ctors: {
            init: function () {
                this.Item = Bridge.getDefaultValue(T);
            },
            ctor: function (item) {
                this.$initialize();
                this.Item = item;
                this.IsRed = true;
            },
            $ctor1: function (item, isRed) {
                this.$initialize();
                this.Item = item;
                this.IsRed = isRed;
            }
        }
    }; });
    /*System.Collections.Generic.SortedSet$1+Node end.*/