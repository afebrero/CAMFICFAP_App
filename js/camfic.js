jQuery.extend({
    camfic: {
        m_getHello: function () {

            $.post('functions/Usuaris.aspx',
		    {
		        
		    },
  		    function (data) {
				alert("hello");				
  		        $("#hello").html("hellooo");
  		    });
        }
    }
});