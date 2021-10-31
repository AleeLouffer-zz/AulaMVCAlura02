class Carrinho {
    clickIncremento(btn) {
        let data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);
    }

    clickDecremento(btn) {
        let data = this.getData(btn);
        data.Quantidade--;
        this.postQuantidade(data);
    }

    updateQuantidade(input) {
        let data = this.getData(input);
        this.postQuantidade(data);
    }

    getData(elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]');
        var itemId = $(linhaDoItem).attr('item-id');
        var novaQtde = $(linhaDoItem).find('input').val();

        return {
            Id: itemId,
            Quantidade: novaQtde
        };
    }

    postQuantidade(data) {
        console.log(data);
        $.ajax({
            url: '/pedido/UpdateQuantidade',
            type: 'POST',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            data: {
                Id: data.Id,
                Quantidade: data.Quantidade
            }
        });
    }
}

var carrinho = new Carrinho();