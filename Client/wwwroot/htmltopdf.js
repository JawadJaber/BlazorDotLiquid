window.htmltopdf = (d) =>
{
    var element = document.getElementById(d);
    var opt = {
        margin: 1,
        filename: 'myfile2.pdf',
        image: { type: 'png', quality: 1 },
        html2canvas: { scale: 2 },
        jsPDF: { unit: 'in', format: 'a4', orientation: 'portrait' }
    };
    html2pdf(element,opt);
    
}