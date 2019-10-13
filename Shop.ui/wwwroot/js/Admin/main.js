var app = new Vue({
    el: '#app',
    //element
    data: {
        price: 0,
        showPrice: true,
        loading: false,

    },
    methods:{
        togglePrice: function () {
            this.showPrice = !this.showPrice;
        },
        alert:function(v) {
            alert(v);
        },
        getProducts: () {
            this.loading = true;
            axios.get('/Admin/products')
                .then (res => {
                    console.log(res);
                })
                .catch (err=> {
                    console.log(err);
                })
                .then (()=> {
                    this.loading = false;
                });
        }
},
    computed: {
        formatPrice: function () {
            return "$" + this.Price;
        }
    }
});