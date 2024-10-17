
function StudentTable(){
    document.write("<table>");
    document.write("<tr>");
    document.write("<td>Name</td>");
    document.write("<td>Saqlain Sheikh</td>");
    document.write("<td>Rahul Singh</td>");
    document.write("<td>Ashwin Mehakare</td>");
    document.write("<td>Ram Haridas</td>");
    document.write("<tr>");
    document.write("<tr>");
    document.write("<td>Roll_No</td>");
    document.write("<td>21</td>");
    document.write("<td>22</td>");
    document.write("<td>23</td>");
    document.write("<td>24</td>");
    document.write("</tr>");
    document.write("<tr>");
    document.write("<td>Subject</td>");
    document.write("<td>Hindi</td>");
    document.write("<td>English</td>");
    document.write("<td>Marathi</td>");
    document.write("<td>maths</td>");
    document.write("</tr>");
    document.write("<tr>");
    document.write("<td>Marks</td>");
    document.write("<td>60</td>");
    document.write("<td>70</td>");
    document.write("<td>80</td>");
    document.write("<td>90</td>");
    document.write("</tr>");
    document.write("</table>");
    }

    function DisplayOnBtnClick(){
        nm=prompt("Enter Name : ");
        alert("hello "+nm);
        console.log(nm);
        document.getElementById("spanId").innerHTML = nm;

    } 