import React,{Component} from 'react';
import { DataTable } from 'primereact/datatable';
import { Column } from 'primereact/column';
import orderApi from '../../Api/orderApi';
class TestDataTable extends Component {
    state = {
        products : []
    };
    
  
    componentDidMount() {
        const orderapi = orderApi();
        orderapi.getAll()
        .then(res => {
          this.setState({ 
            products: res.data.List
          })
        })
        .catch(err => console.log(err));
    }

   render(){
      
   return(

    <DataTable value={this.state.products} tableStyle={{ minWidth: '50rem' }}>
        <Column field="ORDER_NAME" header="ORDER_NAME"></Column>
        <Column field="ORDER_CODE" header="ORDER_TYPE"></Column>
    </DataTable>

   )
   }

}
export default TestDataTable;